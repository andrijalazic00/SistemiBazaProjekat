using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class MailView
    {
        public virtual Istrazivac ID_I { get; set; }
        public virtual string MailAdresa { get; set; }

        public MailView(Mail m)
        {
            ID_I = m.ID_I;
            MailAdresa = m.MailAdresa;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Mail other)) return false;
            return ID_I == other.ID_I && MailAdresa == other.MailAdresa;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}