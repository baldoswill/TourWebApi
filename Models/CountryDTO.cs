using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TourWebApi.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public virtual List<HotelDTO> Hotels { get; set; }
    }
    
    
}