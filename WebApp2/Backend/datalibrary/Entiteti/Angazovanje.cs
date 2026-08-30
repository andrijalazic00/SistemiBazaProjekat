using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Angazovanje
    {
        //public virtual AngazovanjeId Id { get; set; }
        public virtual Istrazivac ID_I { get;  set; }
        public virtual NaucnoIstrazivackaInstitucija ID_NII { get;  set; }
        public virtual DateTime DatumAngazovanja { get; set; }
        public virtual DateTime? DatumZavrsetka { get; set; }
        public virtual string OrganizacionaJedinica { get; set; }
        public virtual string NazivPozicije { get; set; }
        public virtual string TipAngazovanja { get; set; }

        public Angazovanje()
        {
            //Id= new AngazovanjeId();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Angazovanje other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_I.ID_I == other.ID_I.ID_I && ID_NII.ID_NII == other.ID_NII.ID_NII;
        }

        public override int GetHashCode()
        {

            return base.GetHashCode();
        }
    }
}
