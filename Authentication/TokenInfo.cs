using System;
using Microsoft.AspNetCore.Authentication;
using Models.ViewModels.Identity;
using Models.ViewModels.PermitIssuance.Setup;

namespace Authentication
{
    public class TokenInfo
    {
        public TokenInfo() {}

        public TokenInfo(AuthenticationTicket ticket) 
        {
            CreatedAt = DateTime.Now;
            Ticket = ticket;
        }
        
        public DateTime CreatedAt { get; set; }
        
        public AuthenticationTicket Ticket { get; set; }

        public VwUser User { get; set; }
        public VwEPRSUser EPRSUser { get; set; }
    }
}