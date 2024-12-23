using System.ComponentModel.DataAnnotations;

namespace Webtaskapp.Modelsview
{
    public class RegisterViewmodel
    {
        [Required(ErrorMessage = " Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is Required")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The{0} must be at {2}And At max{1} Characters Long")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword",ErrorMessage = "Password Does not Match")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm  Password")]
        public string ConfirmPassword { get; set; }
    }
}
