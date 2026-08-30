using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class OcenaRecenzenta
    {
        public virtual int ID_O {  get; protected set; }
        //public virtual Publikacija ID_P { get;  set; }
        //public virtual Recenzent ID_Recenzenta  { get; set; }
        public virtual AngazovanjeRecenzent AngazovanjeRecenzent { get; set; }
        public virtual int Ocena {  get; set; }

        public OcenaRecenzenta() { }
    }
}
