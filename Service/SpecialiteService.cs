using Domain;
using PS.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class SpecialiteService : Service<Specialite>, ISpecialiteService
    {
        public SpecialiteService(IUnitOfWork utwk) : base(utwk)
        {
        }

        public Specialite GetByMaxAvocats()
        {
            return GetMany().OrderByDescending(s => s.Avocats.Count()).FirstOrDefault();
        }

        
    }
}
