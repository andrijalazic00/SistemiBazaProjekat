using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class DatasetView : IstrazivackiRezultatView
    {
        public virtual string Format { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int BrojZapisa { get; set; }
        public virtual string OpisStrukture { get; set; }
        public virtual string PeriodObuhvataPodataka { get; set; }
        public virtual string LicencaKoriscenja { get; set; }
        public virtual string OgranicenjaPristupa { get; set; }
        public virtual PublikacijaView Publikacija { get; set; }

        public DatasetView(Dataset d) : base(d)
        {
            Format = d.Format;
            Velicina = d.Velicina;
            BrojZapisa = d.BrojZapisa;
            OpisStrukture = d.OpisStrukture;
            PeriodObuhvataPodataka = d.PeriodObuhvataPodataka;
            LicencaKoriscenja = d.LicencaKoriscenja;
            OgranicenjaPristupa = d.OgranicenjaPristupa;
            Publikacija = d.Publikacija == null ? null : new PublikacijaView(d.Publikacija);
        }
    }
}
