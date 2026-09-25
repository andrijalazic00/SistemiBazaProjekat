using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class IstrazivackiRezultatView
    {
        public virtual int ID_IR { get; set; }
        public virtual string? Naslov { get; set; }
        public virtual string? Apstrakt { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual DateTime DatumObjavljivanja { get; set; }
        public virtual string? StatusIR { get; set; }
        public virtual int Vidljivost { get; set; }
        public virtual IList<KljucnaRecView>? KljucneReci { get; set; }
        public virtual IList<VerzijaView>? Verzije {get; set; }
        public virtual IList<PripadajuciFajlView>? PripadajuciFajlovi { get; set; }


        public IstrazivackiRezultatView()
        {
            KljucneReci = [];
            Verzije = [];
            PripadajuciFajlovi = [];
        }
        public IstrazivackiRezultatView( IstrazivackiRezultat i)
        {
            ID_IR = i.ID_IR;
            Naslov = i.Naslov;
            Apstrakt = i.Apstrakt;
            DatumKreiranja = i.DatumKreiranja;
            DatumObjavljivanja = i.DatumObjavljivanja;
            StatusIR = i.StatusIR;
            Vidljivost = i.Vidljivost;
        }
 
    }
}