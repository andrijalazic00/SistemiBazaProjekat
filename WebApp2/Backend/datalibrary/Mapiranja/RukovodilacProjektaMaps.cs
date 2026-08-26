using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
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
