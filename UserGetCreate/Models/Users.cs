using System.ComponentModel.DataAnnotations;

namespace UserGetCreate.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}

