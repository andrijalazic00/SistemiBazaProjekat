using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    public class RecenzentMaps:SubclassMap<Recenzent>
    {
        public RecenzentMaps()
        {
            Table("RECENZENT");
            KeyColumn("ID_U");
            HasMany(x => x.OblastiEkspertize).KeyColumn("ID_U").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.RundeRecenzije).KeyColumn("ID_RECENZENTA").LazyLoad().Cascade.All().Inverse();
            //Id(x => x.ID_U, "ID_U").GeneratedBy.Assigned();
        }
    }
}
