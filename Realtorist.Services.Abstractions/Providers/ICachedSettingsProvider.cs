namespace Realtorist.Services.Abstractions.Providers
{
    /// <summary>
    /// Describes settings provider which contains it's settings in cache
    /// </summary>
    public interface ICachedSettingsProvider : ISettingsProvider
    {
        /// <summary>
        /// Resets cache for a specified 
        /// </summary>
        void ResetSettingCache(string settingType);
    }
}
