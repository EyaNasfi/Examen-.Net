using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class RemboursementService : Service<Remboursement>, IRemboursement
    {
        public RemboursementService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double getMontantTotal(Patient p)
        {
            return GetAll().Where(o => o.BulletinSoin.Patient.Equals(p) && o.DateRemboursement.Year.Equals(DateTime.Now.Year)).Sum(o => o.Montant);
        }
    }
}
