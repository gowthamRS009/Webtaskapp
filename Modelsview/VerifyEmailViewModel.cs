using System.ComponentModel.DataAnnotations;

namespace Webtaskapp.Modelsview
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
