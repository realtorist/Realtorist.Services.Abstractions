using Realtorist.Models.Listings;
using Realtorist.Models.Settings;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Realtorist.Services.Abstractions.Communication
{
    /// <summary>
    /// Describes client which provides methods to work with email
    /// </summary>
    public interface IEmailClient
    {
        /// <summary>
        /// Sends email
        /// </summary>
        /// <param name="message">Email message to send</param>
        Task SendEmailAsync(MailMessage message);

        /// <summary>
        /// Sends email with specific SMTP client settings
        /// </summary>
        /// <param name="message">Message to send</param>
        /// <param name="smtpSettings">SMTP settings</param>
        Task SendEmailAsync(MailMessage message, SmtpSettings smtpSettings);
    }
}
