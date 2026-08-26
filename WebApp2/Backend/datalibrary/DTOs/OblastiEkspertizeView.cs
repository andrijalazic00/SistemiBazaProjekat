using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class OblastiEkspertizeView
    {
        public virtual Recezent ID_U { get;  set; }
        public virtual string Oblast { get;  set; }

        public OblastiEkspertizeView(OblastiEkspertize o)
        {
            ID_U = o.ID_U;
            Oblast = o.Oblast;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is OblastiEkspertize other)) return false;
            return ID_U == other.ID_U && Oblast == other.Oblast;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }    
    }
}