using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class BullteinService : Service<BulletinSoin>,IBulletin
    {
        public BullteinService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public int getnombrebull(Patient p, DateTime d)
        {
            return GetAll().Where(o => o.Patient.Equals(p) && o.DateCreation.Year.Equals(d.Year)).Count();
        }
    }
}
