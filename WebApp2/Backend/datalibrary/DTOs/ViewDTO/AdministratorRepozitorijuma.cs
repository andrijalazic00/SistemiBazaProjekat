using datalibrary.DTOs;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.Entiteti
{
    public class AdministratorRepozitorijumaView: UlogaView
    {
        public virtual IList<AdministratorOvlascenjaView> Ovlascenja {  get; set; }

        public AdministratorRepozitorijumaView(Uloga u): this(u, true)
        {
        }

        public AdministratorRepozitorijumaView(Uloga u, bool includeOvlascenja): base(u)
        {
            var administrator = (AdministratorRepozitorijuma)u;
            Ovlascenja = includeOvlascenja
                ? administrator.Ovlascenja
                    .Select(ovlascenje => new AdministratorOvlascenjaView(ovlascenje))
                    .ToList()
                : new List<AdministratorOvlascenjaView>();
        }

    }
}