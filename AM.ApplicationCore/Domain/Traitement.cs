using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traitement
    {
        public DateTime DateTraitement { get; set; }
        public string Description { get; set; }
        public virtual BulletinSoin BulletinSoin { get; set; }
        public virtual Intervenant Intervenant { get; set; }
        public int IntervenantFk { get; set; }
        public int BulletinFk { get; set; }
    }
}
