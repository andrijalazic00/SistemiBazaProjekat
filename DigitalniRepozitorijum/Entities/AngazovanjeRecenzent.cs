using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Entities
{

        public class AngazovanjeRecenzent
        {
            public virtual Publikacija ID_P { get; protected set; }
            public virtual Recenzent ID_Recenzenta { get; protected set; }
            public virtual int BrojRunde { get; protected set; }
            public virtual string Preporuka { get; set; }
            
            public virtual IList<OcenaRecenzenta> Ocene{get; set;}

            public AngazovanjeRecenzent()
            {
                Ocene=new List<OcenaRecenzenta>();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is AngazovanjeRecenzent other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return ID_P.ID_P == other.ID_P.ID_P && ID_Recenzenta.ID_U == other.ID_Recenzenta.ID_U;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
    
}
