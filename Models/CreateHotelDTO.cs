using System.ComponentModel.DataAnnotations;

namespace TourWebApi.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 500, ErrorMessage = "Address Is Too Long")]
        public string Address { get; set; }
        
        [Required]
        [Range(1, 10)]
        public double Rating { get; set; }
        
        [Required]
        [Range(1, 10)]
        public int CountryId { get; set; }
    }
}