using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class KnjigaIliPoglavlja:IstrazivackiRezultat
    {
        public virtual string Izdavac { get; set; }
        public virtual string MestoIzdavanja { get; set; }

        public virtual IList<Uredjuje> Urednici {  get; set; }

        public KnjigaIliPoglavlja()
        {
            Urednici = new List<Uredjuje>();
        }
    }

}
