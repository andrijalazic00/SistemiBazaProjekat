using datalibrary.Entiteti;
using datalibrary.Mapiranja;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{

    public class UlogaView
    {
        public virtual int ID_U {get; set;}
        public virtual IstrazivacView ID_I { get; set; }

        public UlogaView()
        {
            
        }
        
        public UlogaView( Uloga u )
        {

                ID_U = u.ID_U;
                ID_I = new IstrazivacView(u.ID_I);
        }

    }



}