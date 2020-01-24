using ConsoleDependencyInjection.Services;
using ConsoleDependencyInjection.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Register the services
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISecurityService, SercurityService>()
                .AddSingleton<IAuditService, AuditService>()
                .BuildServiceProvider();

            //Instantiate the security helper, and call the login method
            var secutityHelper = serviceProvider.GetService<ISecurityService>();
            secutityHelper.Login();

            Console.Read();
        }
    }
}
