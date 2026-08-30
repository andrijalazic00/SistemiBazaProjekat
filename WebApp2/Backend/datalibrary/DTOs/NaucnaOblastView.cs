using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class NaucnaOblastView
    {
        public virtual NaucnoIstrazivackaInstitucijaView ID_NII { get; set; }
        public virtual string Oblast { get; set; }

        public NaucnaOblastView(NaucnaOblast n)
        {
            ID_NII = new NaucnoIstrazivackaInstitucijaView( n.ID_NII);
            Oblast = n.Oblast;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NaucnaOblastView other)) return false;
            return ID_NII == other.ID_NII && Oblast == other.Oblast;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
    }
}