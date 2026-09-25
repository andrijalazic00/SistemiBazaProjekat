using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class IstrazivackiRezultat
    {
        public virtual int ID_IR { get; protected set; }
        public virtual string Naslov { get; set; }
        public virtual string Apstrakt { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual DateTime DatumObjavljivanja { get; set; }
        public virtual string StatusIR { get; set; }
        public virtual int Vidljivost { get; set; }

        public virtual IList<KljucnaRec> KljucneReci { get; set; }
        public virtual IList<Verzija> Verzije { get; set; }
        public virtual IList<PripadajuciFajl> PripadajuciFajlovi { get; set; }

        public IstrazivackiRezultat()
        {
            KljucneReci = new List<KljucnaRec>();
            Verzije=new List<Verzija>();
            PripadajuciFajlovi = new List<PripadajuciFajl>();
        }
    }
}
