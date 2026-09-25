using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class VerzijaView
    {
         public virtual IstrazivackiRezultatView ID_IR { get; set; }
        public virtual int BrojVerzije { get;  set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual string OpisIzmena { get; set; }
        public virtual string OdgovornaOsoba { get; set; }
        public virtual IList<PripadajuciFajlView>? PripadajuciFajlovi { get; set; }

        public VerzijaView( Verzija v)
        {
            ID_IR = new IstrazivackiRezultatView( v.ID_IR);
            BrojVerzije = v.BrojVerzije;
            DatumPostavljanja = v.DatumPostavljanja;
            OpisIzmena = v.OpisIzmena;
            OdgovornaOsoba = v.OdgovornaOsoba;
        }

        public VerzijaView()
        {
            PripadajuciFajlovi = new List<PripadajuciFajlView>();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is VerzijaView other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && BrojVerzije == other.BrojVerzije;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}