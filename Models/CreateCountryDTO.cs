using System.ComponentModel.DataAnnotations;

namespace TourWebApi.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 4, ErrorMessage = "Short Name Is Too Long")]
        public string  ShortName { get; set; }
    }
}