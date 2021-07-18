using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourWebApi.IRepository;
using Microsoft.Extensions.Logging;

namespace TourWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public CountryController(IUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            try
            {
                var countries = await _unitOfWork.Countries.GetAll();
                return Ok(countries);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something Went Wrong {nameof(GetCountries)}");
                return StatusCode(500, "Internal Server Error. Please Try Again Later.");
            }
        }
    }
}