using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Entiteti
{
    public class Citat
    {
        public virtual Publikacija ID_P1 { get; protected set; }
        public virtual Publikacija ID_P2 { get; protected set; }
        public virtual string CitirajucaPublikacija { get; protected set; }
        public virtual string CitiranaPublikacija { get; protected set; }
        public virtual string TipCitata { get; set; }
        public virtual string MestoCitiranja { get; set; }
        public virtual string KontekstCitiranja { get; set; }

        public Citat()
        {
        }

        public Citat(Publikacija p1, Publikacija p2,string tipCitata, string mestoCitiranja, string kontekstCitiranja)
        {
            ID_P1= p1;
            ID_P2= p2;
            CitirajucaPublikacija = p1.ID_P.ToString();
            CitiranaPublikacija =p2.ID_P.ToString();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Citat other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_P1.ID_P == other.ID_P1.ID_P && ID_P2.ID_P == other.ID_P2.ID_P;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
