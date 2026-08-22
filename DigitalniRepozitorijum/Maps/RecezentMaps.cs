using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    public class RecezentMaps:SubclassMap<Recezent>
    {
        public RecezentMaps()
        {
            Table("RECENZENT");
            KeyColumn("ID_U");
            HasMany(x => x.OblastiEkspertize).KeyColumn("ID_U").LazyLoad().Cascade.All().Inverse();
            //Id(x => x.ID_U, "ID_U").GeneratedBy.Assigned();
        }
    }
}
