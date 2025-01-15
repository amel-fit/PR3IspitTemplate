using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB230046
{
    [Table("StudentiUloge")]
    public class StudentUlogaIB230046
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int UlogaId { get; set; }

        //[ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
        //[ForeignKey("UlogaId")]
        public virtual UlogaIB230046 Uloga { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
