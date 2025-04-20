using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Matricule { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public virtual IList<BulletinSoin> BulletinSoins { get; set; }

    }
}
