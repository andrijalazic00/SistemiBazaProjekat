using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class AdministratorOvlascenjaView
    {
        public virtual string Ovlascenje { get; set; }
        public virtual AdministratorRepozitorijumaView ID_U {  get; set; }

        public AdministratorOvlascenjaView( AdministratorOvlascenja a)
        {
            Ovlascenje = a.Ovlascenje;
            ID_U = new AdministratorRepozitorijumaView(a.ID_U);
        }


        public override bool Equals(object obj)
        {
            if (obj is not AdministratorOvlascenjaView other) return false;
            return ID_U == other.ID_U && Ovlascenje == other.Ovlascenje;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}