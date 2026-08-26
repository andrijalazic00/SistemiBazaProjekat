using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{

    public class UlogaView
    {
        public virtual Istrazivac ID_I { get; set; }

        public UlogaView()
        {
            
        }
        
        public UlogaView( Uloga u )
        {
                ID_I = u.ID_I;
        }

    }



}