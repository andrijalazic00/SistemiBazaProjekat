using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class KnjigaIliPoglavlja:IstrazivackiRezultat
    {
        //public virtual int ID_IR { get; protected set; }
        public virtual string Izdavac { get; set; }
        public virtual string MestoIzdavanja { get; set; }

        public virtual IList<Uredjuje> Urednici {  get; set; }

        public KnjigaIliPoglavlja()
        {
            Urednici = new List<Uredjuje>();
        }
    }

}
