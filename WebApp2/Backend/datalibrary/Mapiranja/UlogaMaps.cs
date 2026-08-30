using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class UlogaMaps : ClassMap<Uloga>
    {
        public UlogaMaps()
        {
            Table("ULOGA");
            
            Id(x => x.ID_U, "ID_U").GeneratedBy.Sequence("SEQ_ULOGA");
            //Map(x => x.ID_I, "ID_I").Nullable();
            References(x => x.ID_I).Column("ID_I").LazyLoad(); 
           
        }
    }

}
