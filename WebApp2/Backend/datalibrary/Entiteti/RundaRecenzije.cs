using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class RundaRecenzije
    {
        public virtual int BrojRunde { get; set; }
        public virtual Publikacija ID_P { get;  set; }
        public virtual Urednik ID_Urednika { get;  set; }
        public virtual DateTime DatumOdluke { get; set; }
        public virtual string KonacnaOdluka { get; set; }

        public virtual IList<AngazovanjeRecenzent> Recenzenti { get; protected set; }

        public RundaRecenzije()
        {
            Recenzenti = new List<AngazovanjeRecenzent>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RundaRecenzije other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_P.ID_P == other.ID_P.ID_P && BrojRunde == other.BrojRunde;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
