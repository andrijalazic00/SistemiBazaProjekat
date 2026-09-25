using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class UrednikView: UlogaView
    {
        public virtual string UredjivackaSekcija { get; set; }

        public UrednikView( Urednik u): base(u)
        {
            UredjivackaSekcija = u.UredjivackaSekcija;
        }        
    }
}