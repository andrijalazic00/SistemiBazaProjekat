using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DigitalniRepozitorijum.Entities
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
            if (ReferenceEquals(this, other)) return true;
            return ID_I.ID_I == other.ID_I.ID_I && Broj == other.Broj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
