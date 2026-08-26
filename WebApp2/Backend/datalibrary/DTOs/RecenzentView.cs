using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class RecenzentView: UlogaView
    {
       public virtual IList<OblastiEkspertize> OblastiEkspertize { get; set; }

          public RecenzentView():base()
        {
            OblastiEkspertize = new List<OblastiEkspertize>();           
        }
    }
}