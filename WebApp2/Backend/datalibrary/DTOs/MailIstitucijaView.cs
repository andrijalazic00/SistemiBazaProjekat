using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class MailInstitucijaView
    {
        public virtual NaucnoIstrazivackaInstitucija ID_NII {get; set;}
        public virtual string MailAdresa {get; set;}

        public MailInstitucijaView(MailInstitucija m)
        {
            ID_NII = m.ID_NII;
            MailAdresa = m.MailAdresa;
        }
    }
}