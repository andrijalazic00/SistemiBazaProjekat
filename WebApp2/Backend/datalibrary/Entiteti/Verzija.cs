using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.DTOs;

namespace datalibrary.Entiteti
{
    public class Verzija
    {

        public virtual IstrazivackiRezultat ID_IR { get; set; }
        public virtual int BrojVerzije { get;  set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual string OpisIzmena { get; set; }
        public virtual string OdgovornaOsoba { get; set; }
        public virtual IList<PripadajuciFajl> PripadajuciFajlovi { get; set; }

        public Verzija()
        {
            PripadajuciFajlovi = new List<PripadajuciFajl>();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Verzija other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && BrojVerzije == other.BrojVerzije;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
