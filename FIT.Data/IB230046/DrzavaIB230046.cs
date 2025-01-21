using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB230046
{
    [Table("DrzaveIB230046")]
    public class DrzavaIB230046
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }


        //DB context:

        public virtual List<GradIB230046> Gradovi { get; set; }

        //DTO:
        [NotMapped]
        public int BrojGradova => Gradovi.Count;
    }
}
