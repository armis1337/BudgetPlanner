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
using BudgetPlanner2Web.GenericRepository;
using Microsoft.AspNetCore.Http;

namespace BudgetPlanner2Web.Controllers.API
{
    [Produces("application/json")]
    [Route("api/[controller]")] // api/authmanagement
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly IGenericRepository<Category> _categoryRepository;

        public AuthManagementController(UserManager<ApplicationUser> usrmgr, IOptionsMonitor<JwtConfig> options, IGenericRepository<Category> catrepo)
        {
            _userManager = usrmgr;
            _jwtConfig = options.CurrentValue;
            _categoryRepository = catrepo;
        }

        /// <summary>
        /// Registers user
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: /api/AuthManagement/Register
        ///     {
        ///         "email": "user@email.com",
        ///         "password": "Password123!@#"
        ///     }
        ///     
        /// </remarks>
        /// <response code="200">If user has been registered successfully </response>
        /// <response code="400">Bad request</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserAuthRequest user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.Email);

                if (existingUser != null)
                {
                    return BadRequest(new AuthResult()
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
                    UserName = user.Email,
                    Email = user.Email,
                };

                var isCreated = await _userManager.CreateAsync(newUser, user.Password);

                if (isCreated.Succeeded)
                {
                    var token = GenerateJwtToken(newUser);

                    var id = _userManager.GetUserId(User);
                    await _categoryRepository.AddAsync(new Category { Name = "Default", Description = "Default category" }, newUser.Id);
                    await _categoryRepository.SaveAsync();

                    return Ok(new AuthResult()
                    {
                        Result = true,
                        Token = token
                    });
                }

                return new JsonResult(new AuthResult()
                {
                    Result = false,
                    Errors = isCreated.Errors.Select(x => x.Description).ToList()
                })
                { StatusCode = 500 };
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

        /// <summary>
        /// Logs user in
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: /api/AuthManagement/Login
        ///     {
        ///         "email": "user@email.com",
        ///         "password": "Password123!"
        ///     }
        ///     
        /// </remarks>
        /// <response code="200">If user has been logged in successfully </response>
        /// <response code="400">Bad request</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserAuthRequest user)
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
                    new Claim(JwtRegisteredClaimNames.NameId, user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                }),

                Expires = DateTime.UtcNow.AddYears(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var jwtToken = tokenHandler.WriteToken(token);

            return jwtToken;
        }
    }
}
