using System.Threading.Tasks;

namespace Realtorist.Services.Abstractions.Geo
{
    /// <summary>
    /// Describes solution for fixing empty coordinates in listings
    /// </summary>
    public interface ICoordinatesFixer
    {
        /// <summary>
        /// Finds all listings with empty coordinates and launches geo coding for them
        /// </summary>
        Task FixListingsEmptyCoordinates();
    }
}