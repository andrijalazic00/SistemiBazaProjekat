using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class OstaliDokumenti:IstrazivackiRezultat
    {
        public virtual string Opcije { get; set; }

        public OstaliDokumenti()
        {
        }
    }
}
