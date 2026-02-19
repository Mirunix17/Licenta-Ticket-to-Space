using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Licență_sper.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Pentru development - afișează în consolă
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine($"📧 EMAIL TO: {email}");
            Console.WriteLine($"📋 SUBJECT: {subject}");
            Console.WriteLine($"💬 MESSAGE: {htmlMessage}");
            Console.WriteLine("═══════════════════════════════════════");

            return Task.CompletedTask;
        }
    }
}