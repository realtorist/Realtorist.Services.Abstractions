using System.Threading.Tasks;

namespace Realtorist.Services.Abstractions.Providers
{
    /// <summary>
    /// Describes settings provider
    /// </summary>
    public interface ISettingsProvider
    {
        /// <summary>
        /// Gets settings
        /// </summary>
        Task<T> GetSettingAsync<T>(string settingType) where T : new();
    }
}
