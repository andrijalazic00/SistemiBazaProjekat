using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class TehnickiIzvestajMaps : SubclassMap<TehnickiIzvestaj>
    {
        public TehnickiIzvestajMaps()
        {
            Table("TEHNICKI_IZVESTAJ");
            KeyColumn("ID_IR");
            HasOne(x => x.Publikacija).PropertyRef(x => x.TehnickiIzvestajID);
        }
    }
}
