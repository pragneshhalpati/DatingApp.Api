using System;
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

         [Required]
        public string Gender { get; set; }

        [Required]
        public string KnownAs { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegister()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}