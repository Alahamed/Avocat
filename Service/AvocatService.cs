using Domain;
using PS.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class AvocatService : Service<Avocat>, IAvocatService
    {
        public AvocatService(IUnitOfWork utwk) : base(utwk)
        {
        }
    }
}
