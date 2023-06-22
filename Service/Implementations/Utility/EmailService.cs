using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Service.Contracts.Utility;
using Share.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations.Utility
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration  _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmail(EmailDto emailDto)
        {
            var emailmessage = new MimeMessage();
            var from = _config["EmailSettings:From"];
            emailmessage.From.Add(new MailboxAddress("Guardian Vape",from));
            emailmessage.To.Add(new MailboxAddress(emailDto.To, emailDto.To));
            emailmessage.Subject=emailDto.Subject;
            emailmessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = string.Format(emailDto.Contetnt)
            };

            using (var client= new SmtpClient())
            {
                try
                {
                    client.Connect(_config["EmailSettings:SmtpServer"], 465, true);
                    client.Authenticate(_config["EmailSettings:From"], _config["EmailSettings:Password"]);
                    client.Send(emailmessage);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally 
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }

        }
    }
}
