using AutoMapper;
using TourWebApi.Data;
using TourWebApi.Models;

namespace TourWebApi.Configurations
{
    public class MapperIntializer : Profile
    {
        public MapperIntializer()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();  
            CreateMap<Country, CreateCountryDTO>().ReverseMap();  
            CreateMap<Hotel, HotelDTO>().ReverseMap();  
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();  
        }
        
    }
}