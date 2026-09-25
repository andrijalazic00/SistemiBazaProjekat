using datalibrary.Entiteti;
using NHibernate.Linq.Functions;

namespace datalibrary.DTOs
{
    public class CitatView
    {
        public virtual PublikacijaView ID_P1 { get; set; }
        public virtual PublikacijaView ID_P2 { get; set; }
        public virtual string CitirajucaPublikacija { get; set; }
        public virtual string CitiranaPublikacija { get; set; }
        public virtual string TipCitata { get; set; }
        public virtual string MestoCitiranja { get; set; }
        public virtual string KontekstCitiranja { get; set; }

        public CitatView(Citat c)
        {
            ID_P1 = new PublikacijaView( c.ID_P1);
            ID_P2 = new PublikacijaView( c.ID_P2);
            CitirajucaPublikacija = c.CitirajucaPublikacija;
            CitiranaPublikacija = c.CitiranaPublikacija;
            TipCitata = c.TipCitata;
            MestoCitiranja = c.MestoCitiranja;
            KontekstCitiranja = c.KontekstCitiranja;
        }
    }
}
