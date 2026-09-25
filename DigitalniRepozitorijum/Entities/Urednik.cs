using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Urednik:Uloga
    {
        public virtual string UredjivackaSekcija { get; set; }
        public virtual IList<RundaRecenzije> RundeRecenzije {  get; set; }
        public virtual IList<Uredjuje> Knjige {  get; set; }

        public Urednik()
        {
            RundeRecenzije = new List<RundaRecenzije>();
            Knjige=new List<Uredjuje>();
        }
    }
}
