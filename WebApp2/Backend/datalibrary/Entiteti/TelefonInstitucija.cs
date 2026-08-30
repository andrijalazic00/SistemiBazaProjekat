using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class TelefonInstitucija
    {
        public virtual NaucnoIstrazivackaInstitucija ID_NII { get;  set; }
        public virtual string Broj { get;  set; }

        public TelefonInstitucija()
        {

        }

        public override bool Equals(object obj)
        {
            if (!(obj is TelefonInstitucija other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_NII.ID_NII == other.ID_NII.ID_NII && Broj == other.Broj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
