using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class OcenaRecenzenta
    {
        public virtual int ID_O {  get; protected set; }
        public virtual AngazovanjeRecenzent AngazovanjeRecenzent { get; set; }
        public virtual int Ocena {  get; set; }

        public OcenaRecenzenta() { }
    }
}
