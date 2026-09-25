using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class AutorView: UlogaView
    {
        public virtual string Orcid { get; set; }

        public AutorView( Autor a): base(a)
        {
            Orcid = a.Orcid;
        }       
    }
}