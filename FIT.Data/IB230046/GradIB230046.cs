using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{
    [Table("GradoviIB230046")]
    public class GradIB230046
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }

        //DB context:
        public virtual DrzavaIB230046 Drzava { get; set; }

        //DTO:

    }
}
