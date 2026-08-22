using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Uloga
    {
        public virtual int ID_U { get; protected set; }
        //public virtual int? ID_I { get; set; }
        public virtual Istrazivac ID_I { get; set; }


        //public virtual Autor Autor { get; set; }


        public Uloga()
        {

        }
    }
}
