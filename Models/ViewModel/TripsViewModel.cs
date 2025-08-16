using System.ComponentModel.DataAnnotations;

namespace Eagle.Models.ViewModel
{
    public class TripsViewModel
    {

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


        [Required(ErrorMessage = "Price is required.")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public IEnumerable<Trip>? Trips { get; set; }

        [Required]
        public int SectionId { get; set; }


        public Section? Section { get; set; }
    }
}
