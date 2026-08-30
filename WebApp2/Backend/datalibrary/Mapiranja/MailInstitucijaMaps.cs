using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    public class MailInstitucijaMaps:ClassMap<MailInstitucija>
    {
        public MailInstitucijaMaps()
        {
            Table("MAIL_INSTITUCIJA");
            CompositeId()
                .KeyReference(x => x.ID_NII, "ID_NII")
                .KeyProperty(x => x.MailAdresa, "MAIL");
            //References(x=> x.PripadaInstituciji).Column("ID_NII").LazyLoad();
        }
    }
}
