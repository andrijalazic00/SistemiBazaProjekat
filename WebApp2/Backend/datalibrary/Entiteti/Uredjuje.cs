using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Uredjuje
    {
        public virtual KnjigaIliPoglavlja ID_IR { get; protected set; }
        public virtual Urednik ID_Urednika { get; protected set; }

        public Uredjuje()
        {
        }

        public Uredjuje(KnjigaIliPoglavlja knjiga, Urednik u)
        {
            ID_IR = knjiga;
            ID_Urednika = u;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Uredjuje other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && ID_Urednika.ID_U == other.ID_Urednika.ID_U;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
