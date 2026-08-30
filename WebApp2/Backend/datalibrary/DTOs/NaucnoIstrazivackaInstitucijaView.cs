using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class NaucnoIstrazivackaInstitucijaView
    {
        public virtual int ID_NII { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa {get;set;} 
        public virtual IList<MailInstitucijaView>? Mailovi {  get; set; }
        public virtual IList<TelefonInstitucijaView>? Telefoni {  get; set; }
        public virtual IList<NaucnaOblastView>? NaucneOblasti {  get; set; }

        public NaucnoIstrazivackaInstitucijaView()
        {
            Mailovi = new List<MailInstitucijaView>();
            Telefoni = new List<TelefonInstitucijaView>();
            NaucneOblasti = new List<NaucnaOblastView>();
        }
        public NaucnoIstrazivackaInstitucijaView(NaucnoIstrazivackaInstitucija n)
        {
            ID_NII = n.ID_NII;
            Naziv = n.Naziv;
            Adresa = n.Adresa;
        }
    }
}