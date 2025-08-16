using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eagle.Models
{
   
    public class Section
    {
        [Key]
        public int SectionId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "tblSection Name is required")]
        [StringLength(50, ErrorMessage = "tblSection Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        public IEnumerable<Trip>? Trips { get; set; }

     
    }
}
