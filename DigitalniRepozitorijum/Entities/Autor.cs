using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Autor:Uloga
    {
        public virtual string Orcid { get; set; }
        public virtual IList<Autorstvo> Autorstva { get; set; }

        public Autor()
        {
            Autorstva = new List<Autorstvo>();
        }
    }
}
