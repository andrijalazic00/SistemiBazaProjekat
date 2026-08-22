using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class AutorMaps : SubclassMap<Autor>
    {
        public AutorMaps()
        {
            Table("AUTOR");
            KeyColumn("ID_U");
            Map(x => x.Orcid, "ORCID").Not.Nullable();

            //HasOne(x => x.Uloga).Constrained().Cascade.All();
        }
    }
}
