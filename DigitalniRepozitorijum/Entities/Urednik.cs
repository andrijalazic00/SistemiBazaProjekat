using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Urednik:Uloga
    {
        //public virtual int ID_U { get; protected set; }
        public virtual string UredjivackaSekcija { get; set; }

        public Urednik()
        {
        }
    }
}
