using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Publikacija
    {
        public virtual int ID_P { get; protected set; }
        public virtual IstrazivackiRezultat ID_IR { get; set; }

        public virtual IList <Angazovanje> Publikacije {  get; set; }
        public virtual IList<RundaRecenzije> RundeRecenzije { get; set; }

        //public virtual IList <Angazovanje> CitiranePublikacije { get; set; }

        public Publikacija()
        {
            Publikacije=new List<Angazovanje>();
           // CitiranePublikacije=new List<Angazovanje>();
           RundeRecenzije=new List<RundaRecenzije>();
        }
    }
}
