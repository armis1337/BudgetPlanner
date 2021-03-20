using System.ComponentModel.DataAnnotations;

namespace BudgetPlanner2Web.Models.DTO.Requests
{
    public class UserLoginRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
