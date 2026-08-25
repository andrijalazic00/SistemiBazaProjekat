using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{
    public class Autorstvo
    {
        public virtual Autor ID_U { get;protected set; }
        public virtual Publikacija ID_P { get; protected set; }
        public virtual int RedniBrojAutora { get; set; }
        public virtual string TipDoprinosa { get; set; }
        public virtual string UlogaUPublikaciji { get; set; }

        public Autorstvo()
        {
        }

        public Autorstvo(Autor a, Publikacija p)
        {
            ID_U = a;
            ID_P = p;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Autorstvo other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_U.ID_U == other.ID_U.ID_U && ID_P.ID_P == other.ID_P.ID_P;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
