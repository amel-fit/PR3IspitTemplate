using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{
    [Table("SpolIB230046")]
    public class SpolIB230046
    {
        public int Id { get; set; }
        public string Opis { get; set; }

        public virtual List<Student> StudentSpol { get; set; }
    }
}
