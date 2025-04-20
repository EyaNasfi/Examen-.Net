using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IBulletin:IService<BulletinSoin>
    {
        int getnombrebull(Patient p, DateTime d);
    }
}
