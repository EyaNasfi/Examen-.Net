using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class TraitementService : Service<Traitement>, ITraitement
    {
        public TraitementService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
