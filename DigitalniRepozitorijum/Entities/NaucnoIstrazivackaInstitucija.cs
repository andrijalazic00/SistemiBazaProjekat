using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class NaucnoIstrazivackaInstitucija
    {
        public virtual int ID_NII { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa {get;set;}
        public NaucnoIstrazivackaInstitucija()
        {
            
        }
        
    }
}
