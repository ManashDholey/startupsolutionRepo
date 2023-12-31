﻿using Microsoft.AspNetCore.Authorization;

namespace PriceOptimizerCoreApplication.web.Authorization
{
    public class WorksForCompanyRequirement : IAuthorizationRequirement
    {
        public string DomainName { get; }
        public WorksForCompanyRequirement(string domainName)
        {
            DomainName = domainName;
        }
    }
}
