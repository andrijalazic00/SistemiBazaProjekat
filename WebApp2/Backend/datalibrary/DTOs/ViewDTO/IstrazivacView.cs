using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class IstrazivacView
    {
        public virtual int ID_I { get; set; }
        public virtual string Ime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string NaucnaOblast { get; set; }
        public virtual string NaucnoZvanje { get; set; }
        public virtual string StatusNaucnika { get; set; }

        public virtual IList<MailView>? Mailovi { get; set; }
        public virtual IList<TelefonView>? Telefoni { get; set; }
        public virtual IList<UlogaView>? Uloge {  get; set; }
        public virtual IList<AngazovanjeView>? Institucije { get; set; }   

        public IstrazivacView()
        {
            Mailovi = new List<MailView>();
            Telefoni = new List<TelefonView>();
            Uloge = new List<UlogaView>();
            Institucije = new List<AngazovanjeView>();
        }    

        public IstrazivacView(Istrazivac i)
        {
            ID_I = i.ID_I;
            Ime = i.Ime;
            DatumRodjenja = i.DatumRodjenja;
            Drzava = i.Drzava;
            Prezime = i.Prezime;
            NaucnaOblast = i.NaucnaOblast;
            NaucnoZvanje = i.NaucnoZvanje;
            StatusNaucnika = i.StatusNaucnika;
        }
    }
}
