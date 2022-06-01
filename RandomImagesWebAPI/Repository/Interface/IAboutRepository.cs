using RandomImagesWebAPI.Models;

namespace RandomImagesWebAPI.Repository.Interface
{
    /// <summary>
    /// This interface contains about the application methods used to communicate with the database
    /// </summary>
    public interface IAboutRepository
    {
        Task<About> GetAboutInformationAsync();
    }
}
