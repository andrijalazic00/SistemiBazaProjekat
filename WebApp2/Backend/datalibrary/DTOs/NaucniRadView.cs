using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class NaucniRadView : IstrazivackiRezultatView
    {
        public virtual string TipRada { get; set; }
        public virtual string NazivCasKon { get; set; }
        public virtual string Doi { get; set; }
        public virtual string IssnIliIsbn { get; set; }
        public virtual int BrojSveske { get; set; }
        public virtual int BrojIzdanja { get; set; }
        public virtual int BrojStranice { get; set; }

        public NaucniRadView(NaucniRad n) : base(n)
        {
            TipRada = n.TipRada;
            NazivCasKon = n.NazivCasKon;
            Doi = n.Doi;
            IssnIliIsbn = n.IssnIliIsbn;
            BrojSveske = n.BrojSveske;
            BrojIzdanja = n.BrojIzdanja;
            BrojStranice = n.BrojStranice;
        }
    }
}
