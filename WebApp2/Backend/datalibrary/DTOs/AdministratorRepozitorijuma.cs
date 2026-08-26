using datalibrary.DTOs;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.Entiteti
{
    public class AdministratorRepozitorijumaView: UlogaView
    {
        public virtual IList<AdministratorOvlascenja> Ovlascenja {  get; set; }

        public AdministratorRepozitorijumaView(Uloga u): base(u)
        {
            Ovlascenja = new List<AdministratorOvlascenja>();
        }

    }
}