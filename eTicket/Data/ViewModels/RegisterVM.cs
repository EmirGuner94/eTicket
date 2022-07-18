using System.ComponentModel.DataAnnotations;

namespace eTicket.Data.ViewModels
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Password do not match")]
        [Display(Name = "Confirm password")]
        public string ConrfimPassword { get; set; }
    }
}
