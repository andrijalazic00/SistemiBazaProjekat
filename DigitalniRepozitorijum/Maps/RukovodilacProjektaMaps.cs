using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;

namespace DigitalniRepozitorijum.Maps
{
    public class RukovodilacProjektaMaps:SubclassMap<RukovodilacProjekta>
    {
        public RukovodilacProjektaMaps()
        {
            Table("RUKOVODILAC_PROJEKTA");
            KeyColumn("ID_U");
            //Id(x => x.ID_U, "ID_U").GeneratedBy.Assigned();
        }
    }
}
