using Domain;
using PS.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
