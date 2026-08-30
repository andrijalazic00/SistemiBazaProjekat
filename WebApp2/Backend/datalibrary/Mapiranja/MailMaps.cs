using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    public class MailMaps : ClassMap<Mail>
    {
        public MailMaps()
        {
            Table("MAIL");
            CompositeId()
                .KeyReference(x => x.ID_I, "ID_I")
                .KeyProperty(x => x.MailAdresa, "MAIL");
            
        }
    }
}
