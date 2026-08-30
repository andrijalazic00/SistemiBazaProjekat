using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class MailInstitucijaView
    {
        public virtual NaucnoIstrazivackaInstitucijaView ID_NII {get; set;}
        public virtual string MailAdresa {get; set;}

        public MailInstitucijaView(MailInstitucija m)
        {
            ID_NII = new NaucnoIstrazivackaInstitucijaView(m.ID_NII);
            MailAdresa = m.MailAdresa;
        }

        public MailInstitucijaView()
        {
            
        }
    }
}