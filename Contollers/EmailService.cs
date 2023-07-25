using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WebApiHotel.Contollers
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            using var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Адміністратор ГКК", "viktoria3003vita@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(email, 995);
                await client.AuthenticateAsync("viktoria3003vita@gmail.com", "Vfvfktyf20023003");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    


    }
}
