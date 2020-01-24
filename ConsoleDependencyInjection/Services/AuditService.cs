using ConsoleDependencyInjection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDependencyInjection.Services
{
    public class AuditService : IAuditService
    {
        public void Log()
        {
            Console.WriteLine("Audit action");
        }
    }
}
