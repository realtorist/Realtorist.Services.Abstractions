namespace Realtorist.Services.Abstractions.Providers
{
    /// <summary>
    /// Describes provider for the encryption
    /// </summary>
    public interface IEncryptionProvider
    {
        /// <summary>
        /// Gets encrypt string with one-way encryption
        /// </summary>
        /// <returns>Encrypted string</returns>
        string EncryptOneWay(string input);

        /// <summary>
        /// Gets encrypted string with two-way encryption
        /// </summary>
        /// <returns>Encrypted string</returns>
        /// <returns>Secret</returns>
        string EncryptTwoWay(string input);

        /// <summary>
        /// Gets decrypted string with two-way encryption
        /// </summary>
        /// <returns>Decrypted string</returns>
        string Decrypt(string input);
    }
}
