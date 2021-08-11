namespace Realtorist.Services.Abstractions.Providers
{
    /// <summary>
    /// Describes provider which helps to generate links
    /// </summary>
    public interface ILinkProvider
    {
        /// <summary>
        /// Gets an absolute link from the relative one
        /// </summary>
        /// <returns>Absolute link</returns>
        string GetAbsoluteLink(string relativeLink);
    }
}
