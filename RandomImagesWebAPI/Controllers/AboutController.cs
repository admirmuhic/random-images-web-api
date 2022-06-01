using Microsoft.AspNetCore.Mvc;
using RandomImagesWebAPI.Repository.Interface;
using RandomImagesWebAPI.Models;

namespace RandomImagesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        [HttpGet]
        public async Task<ActionResult<About>> GetAboutInformation()
        {
            var about = await _aboutRepository.GetAboutInformationAsync();

            if (about == null)
                return NotFound();

            return Ok(about);
        }
    }
}
