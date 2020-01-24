using ConsoleDependencyInjection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDependencyInjection.Services
{
    public class SercurityService : ISecurityService
    {
        private readonly IAuditService _auditService;

        public SercurityService(IAuditService auditService)
        {
            _auditService = auditService;
        }

        public void Login()
        {
            Console.WriteLine("Log user in");
            _auditService.Log();
        }
    }
}
