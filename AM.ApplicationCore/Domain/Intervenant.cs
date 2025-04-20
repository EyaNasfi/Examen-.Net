using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum TypeIntervenant {Medecin,Pharmacien,AgentAssurance }
    public class Intervenant
    {
        public int IntervenantId { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Telephone { get; set; }
        public TypeIntervenant TypeIntervenant { get; set; }
        public virtual IList<Traitement> Traitements { get; set; }
    }
}
