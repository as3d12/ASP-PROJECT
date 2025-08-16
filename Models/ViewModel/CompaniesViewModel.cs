using System.ComponentModel.DataAnnotations;

namespace Eagle.Models.ViewModel
{
	public class CompaniesViewModel
	{
        //Search Attributes:

        [StringLength(100, ErrorMessage = "name cannot exceed 100 characters")]
		[RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "name can only contain letters, numbers, and spaces")]
		public string Name { get; set; }

		[StringLength(100, ErrorMessage = " Location cannot exceed 100 characters")]
		[RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Location can only contain letters, numbers, and spaces")]
		public string Location { get; set; }

		[EmailAddress(ErrorMessage = "Invalid email address format")]
		public string Email { get; set; }

		[Phone(ErrorMessage = "Invalid phone number format")]
		[StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
		public string Phone { get; set; }

        //Search Result:
		public IEnumerable<Company>? Companies { get; set; }
    }
}
