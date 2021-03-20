using BudgetPlanner2Web.Configuration;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetPlanner2Web.Models.DTO.Requests;
using BudgetPlanner2Web.Models.DTO.Responses;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace BudgetPlanner2Web.Controllers.API
{
    [Route("api/[controller]")] // api/authmanagement
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtConfig _jwtConfig;

        public AuthManagementController(UserManager<ApplicationUser> usrmgr, IOptionsMonitor<JwtConfig> options)
        {
            _userManager = usrmgr;
            _jwtConfig = options.CurrentValue;
        }

        [HttpGet]
        public string Index()
        {
            return "hello world!!!!";
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequestDto user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)
                {
                    return BadRequest(new RegistrationResponse()
                    {
                        Result = false,
                        Errors = new List<string>()
                        {
                            "Email already exists"
                        }
                    });
                }

                var newUser = new ApplicationUser()
                {
                    Email = user.Email,
                    UserName = user.Email
                };

                var isCreated = await _userManager.CreateAsync(newUser, user.Password);
            
                if (isCreated.Succeeded)
                {
                    var token = GenerateJwtToken(newUser);

                    return Ok(new RegistrationResponse()
                    {
                        Result = true,
                        Token = token
                    });
                }

                return new JsonResult(new RegistrationResponse()
                {
                    Result = false,
                    Errors = isCreated.Errors.Select(x => x.Description).ToList()
                })
                { StatusCode = 500 };
            }

            return BadRequest(new RegistrationResponse()
            {
                Result = false,
                Errors = new List<string>()
                {
                    "Invalid payload"
                }
            });
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser == null)
                {
                    return BadRequest(new AuthResult()
                    {
                        Result = false,
                        Errors = new List<string>()
                        {
                            "Invalid login request"
                        }
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

                if (isCorrect)
                {
                    var jwtToken = GenerateJwtToken(existingUser);

                    return Ok(new AuthResult()
                    {
                        Result = true,
                        Token = jwtToken
                    });
                }
                else
                {
                    return BadRequest(new AuthResult()
                    {
                        Result = false,
                        Errors = new List<string>()
                        {
                            "Invalid login request"
                        }
                    });
                }
            }

            return BadRequest(new AuthResult()
            {
                Result = false,
                Errors = new List<string>()
                {
                    "Invalid payload"
                }
            });
        }

        private string GenerateJwtToken(ApplicationUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    //new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),

                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),

                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = tokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}
