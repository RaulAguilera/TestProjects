using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace GetMessages
{
    class Program
    {
        static string TOKEN = "";
        static string DESTINATION_MAIL = "";
        static void Main(string[] args)
        {
            var client = new GraphServiceClient(new DelegateAuthenticationProvider(async request =>
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("bearer", TOKEN);

            }));

            var messages = client.Me.Messages.Request()
                .Select(m => new { m.Subject, m.SentDateTime })
                .Filter("hasAttachments eq true")
                .Top(10)
                .GetAsync().Result;

            foreach (var item in messages)
            {
                Console.WriteLine($"{item.Subject} {item.SentDateTime}");
            }

            var myMessage = new Message()
            {
                ToRecipients = new List<Recipient>
                { new Recipient() { EmailAddress = new EmailAddress() { Address = DESTINATION_MAIL}}
                },
                Subject = "Hey from .NET",
                Body = new ItemBody()
                {
                    ContentType = BodyType.Text,
                    Content = "Hello dear!!!"
                }
            };

            client.Me.SendMail(myMessage).Request().PostAsync();

            Console.ReadKey();
        }
    }
}
