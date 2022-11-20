using UsuariosApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                   webBuilder.UseStartup<Startup>();
                })
            .ConfigureAppConfiguration((context, builder) =>
            builder.AddUserSecrets<Program>());
        /*
            "EmailSettings": {
             "From": "samuelborges1503@gmail.com", // Por quest�es de seguran�a n�o coloquei o nome do meu email. 
             "SmtpServer": "smtp.gmail.com",
             "Port": "465",
             "Password": "Samuel1503032003@" // Por quest�es de seguran�a n�o coloquei a minha senha de email.
            }
        */




    }
}
