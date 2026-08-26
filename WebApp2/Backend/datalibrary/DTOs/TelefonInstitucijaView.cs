using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class TelefonInstitucijaView
    {
        public virtual NaucnoIstrazivackaInstitucija ID_NII { get;  set; }
        public virtual string Broj { get;  set; } 

        public TelefonInstitucijaView(TelefonInstitucija t)
        {
            ID_NII = t.ID_NII;
            Broj = t.Broj;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is TelefonInstitucija other)) return false;
            return ID_NII == other.ID_NII && Broj == other.Broj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }      
    }

    
}