using System.ComponentModel.DataAnnotations;
namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Phone")]
        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please respond will attend")]
        public bool? WillAttend { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }
    }
}