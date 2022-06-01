using Microsoft.EntityFrameworkCore;
using RandomImagesWebAPI.Repository.Interface;
using RandomImagesWebAPI.Models;

namespace RandomImagesWebAPI.Repository
{
    public class AboutRepository : IAboutRepository
    {
        private readonly ApplicationDbContext _context;

        public AboutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Use this method to retrieve about the application information
        /// </summary>
        /// <returns>About object</returns>
        public async Task<About> GetAboutInformationAsync()
        {
            var about = await _context.About.FirstOrDefaultAsync();

            if (about == null)
                return null;

            return new About
            {
                Heading = about.Heading,
                Information = about.Information,
                Date = about.Date
            };
        }
    }
}
