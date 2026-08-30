using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class PripadajuciFajlView
    {
        public virtual IstrazivackiRezultatView ID_IR { get; protected set; }
        public virtual int BrojVerzije { get; protected set; }
        public virtual string NazivFajla { get; protected set; }

        public PripadajuciFajlView()
        {
        }

        public PripadajuciFajlView( PripadajuciFajl p)
        {
            ID_IR = new IstrazivackiRezultatView( p.ID_IR);
            BrojVerzije = p.BrojVerzije;
            NazivFajla = p.NazivFajla;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PripadajuciFajlView other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ID_IR.ID_IR == other.ID_IR.ID_IR && BrojVerzije == other.BrojVerzije && NazivFajla == other.NazivFajla;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }     
    }
}