using datalibrary.Entiteti;
using datalibrary.Mapiranja;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{

    public class UlogaView
    {
        public virtual int ID_U {get; set;}
        public virtual string NazivUloge { get; set; }
         public virtual IstrazivacView ID_I { get; set; }

        public UlogaView()
        {
            
        }
        
        public UlogaView( Uloga u )
        {

                ID_U = u.ID_U;
                NazivUloge = u switch
                {
                    Autor => "Autor",
                    Recenzent => "Recenzent",
                    Urednik => "Urednik",
                    RukovodilacProjekta => "Rukovodilac projekta",
                    AdministratorRepozitorijuma => "Administrator repozitorijuma",
                    _ => "Uloga"
                };
                ID_I = new IstrazivacView(u.ID_I);
        }

    }



}