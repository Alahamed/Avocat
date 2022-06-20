using Domain;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IDossierService: IService<Dossier>
    {
        public IList<Client> GetClients(Avocat avocat);

        public int GetNbBySpecialite(Dossier dossier);

        public void Reduction(Dossier dossier);
    }
}
