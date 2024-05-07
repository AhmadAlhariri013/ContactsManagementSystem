using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]([0-9]{3})[-. ]([0-9]{4})$", ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }
    }
}
