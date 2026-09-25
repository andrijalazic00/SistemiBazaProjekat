using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class RecenzentView: UlogaView
    {
       public virtual IList<OblastiEkspertizeView> OblastiEkspertize { get; set; }

          public RecenzentView():base()
        {
            OblastiEkspertize = new List<OblastiEkspertizeView>();           
        }

        public RecenzentView(Recenzent r): base(r)
        {
            
        }
    }
}