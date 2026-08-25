using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class TehnickiIzvestaj:IstrazivackiRezultat
    {
        //public virtual int ID_IR { get; protected set; }
        public virtual Publikacija Publikacija { get; set; }

        public TehnickiIzvestaj()
        {
        }
    }
}
