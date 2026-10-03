using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Autor:Uloga
    {
        //public virtual int ID_U { get; protected set; }
        public virtual string Orcid { get; set; }
        //public virtual Uloga Uloga { get; set; }
        public virtual IList<Autorstvo> Autorstva { get; set; }
        public Autor()
        {
            Autorstva = new List<Autorstvo>();
        }
    }
}
