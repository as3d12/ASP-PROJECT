using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eagle.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

       
        [Required(ErrorMessage = "tblCompany name is required")]
        [StringLength(100, ErrorMessage = "tblCompany name cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "tblCompany name can only contain letters, numbers, and spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "tblCompany Location is required")]
        [StringLength(100, ErrorMessage = "tblCompany Location cannot exceed 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "tblCompany Location can only contain letters, numbers, and spaces")]
        public string Location { get; set; }


        [Required(ErrorMessage = "Contact email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Contact phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
        public string Phone { get; set; }


        public IEnumerable<TripCompany>? TripCompanies { get; set; }
    }
}
