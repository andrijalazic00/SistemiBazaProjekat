using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Verzija
    {

        public virtual IstrazivackiRezultat ID_IR { get; set; }
        public virtual int BrojVerzije { get;  set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual string OpisIzmena { get; set; }
        public virtual string OdgovornaOsoba { get; set; }

        public Verzija()
        {
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Verzija other)) return false;
            return ID_IR == other.ID_IR && BrojVerzije == other.BrojVerzije;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
