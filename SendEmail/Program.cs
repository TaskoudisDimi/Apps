using FluentEmail.Smtp;
using System;
using System.Net.Mail;
using System.Threading.Tasks;
using FluentEmail.Core;

namespace SendEmail
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory,
                PickupDirectoryLocation = @"E:\tutorials"

            });
            Email.DefaultSender = sender;

            var email = await Email
                .From("test@gmail.com")
                .To("destination@gmail.com")
                .Subject("Thanks")
                .Body("Thanks for buying our product.")
                .SendAsync();


        }
    }
}