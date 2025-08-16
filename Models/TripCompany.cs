using System.ComponentModel.DataAnnotations;

namespace Eagle.Models
{
    public class TripCompany
    {
        [Key]
        public int TripCompanyId { get; set; }

        public int CompanyId { get; set; }

        public int TripId { get; set; }


        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Responsible { get; set; }

        public StatusEnum Status { get; set; }
        public Trip? Trip { get; set; }

        public Company? Company { get; set; }
    }
}
