using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class AngazovanNIIInstitucijiView
    {
        public virtual int ID_NII { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Adresa {get;set;} 
        public virtual IList<MailInstitucijaView>? Mailovi {  get; set; }
        public virtual IList<TelefonInstitucijaView>? Telefoni {  get; set; }
        public virtual IList<NaucnaOblastView>? NaucneOblasti {  get; set; }

        public AngazovanNIIInstitucijiView()
        {
            Mailovi = new List<MailInstitucijaView>();
            Telefoni = new List<TelefonInstitucijaView>();
            NaucneOblasti = new List<NaucnaOblastView>();
        }
        public AngazovanNIIInstitucijiView(NaucnoIstrazivackaInstitucija n)
        {
            ID_NII = n.ID_NII;
            Naziv = n.Naziv;
            Adresa = n.Adresa;
        }

        public AngazovanNIIInstitucijiView(NaucnoIstrazivackaInstitucijaView n)
        {
            ID_NII = n.ID_NII;
            Naziv = n.Naziv;
            Adresa = n.Adresa;
        }
    }
}