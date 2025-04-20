using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class BulletinSoin
    {
        public int BulletinSoinId { get; set; }
        public int Numero { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual IList<Remboursement> Remboursements { get; set; }
        public virtual IList<Traitement> Traitements { get; set; }
        public int PatientFk { get; set; }
    }
}
