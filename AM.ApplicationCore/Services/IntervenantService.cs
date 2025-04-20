using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class IntervenantService : Service<Intervenant>, IntervenantInterface
    {
        public IntervenantService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public string GetMedecinNom(Patient p)
        {
            return GetAll().Where(o => o.Traitements.Any(o => o.BulletinSoin.Patient.Equals(p)) && o.TypeIntervenant.Equals("Medecin")).Select(p => p.Nom).OrderByDescending(o=>o.Count()).First();
        }
    }
}
