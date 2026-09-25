using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{
    public class TelefonView
    {
        // public IstrazivacView ID_I {get; set;}
        public virtual string Broj {get; set;}

        public TelefonView(Telefon t)
        {
            // ID_I = new IstrazivacView( t.ID_I);
            Broj = t.Broj;
        }

        // public override bool Equals(object obj)
        // {
        //     if (!(obj is TelefonView other)) return false;
        //     return ID_I == other.ID_I && Broj == other.Broj;
        // }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}