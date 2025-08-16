using System;
using System.ComponentModel.DataAnnotations;
using static System.Collections.Specialized.BitVector32;

namespace Eagle.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date)]
        public DateOnly StartDate { get; set; }


        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }


        [Required(ErrorMessage = "Start time is required.")]
        [DataType(DataType.Time)]
        public TimeOnly StartTime { get; set; }


        [Required(ErrorMessage = "End time is required.")]
        [DataType(DataType.Time)]
        public TimeOnly EndTime { get; set; }


        [Required(ErrorMessage = "Price is required.")]
        [Range(100, 50000, ErrorMessage = "Please enter correct value")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        public int SectionId { get; set; }


        public Section? Section { get; set; }


        public IEnumerable<TripCompany>? TripCompanies { get; set; }

    }
}



