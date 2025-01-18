using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{
    [Table("Premeti")]
    public class PredmetIB230046
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public SemestarIB230046 Semestar { get; set; }
    }
}
