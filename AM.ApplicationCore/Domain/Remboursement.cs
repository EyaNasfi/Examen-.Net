using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Remboursement
    {
        public int RemboursementId { get; set; }
        [Required(ErrorMessage ="Le montant est un champ obligatoire")]
        public double Montant { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRemboursement { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [ForeignKey("BulletinFk")]
        public virtual BulletinSoin BulletinSoin { get; set; }
        public int BulletinFk { get; set; }
    }
}
