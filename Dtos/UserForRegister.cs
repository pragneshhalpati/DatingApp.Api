using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
   public class UserForRegister
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(10,MinimumLength=6,ErrorMessage="You must specify password between 6 to 10 character.")]
        public string Password { get; set; }
    }
}