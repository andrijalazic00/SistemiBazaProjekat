using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace datalibrary.Entiteti
{
    public class Telefon
    {
        public virtual Istrazivac ID_I { get; set; }
        public virtual string Broj { get; set; }

        public Telefon()
        {

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Telefon other)) return false;
            return ID_I == other.ID_I && Broj == other.Broj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
