using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class AutorstvoView
    {
        public virtual AutorView ID_U { get; set; }
        public virtual PublikacijaView ID_P { get; set; }
        public virtual int RedniBrojAutora { get; set; }
        public virtual string TipDoprinosa { get; set; }
        public virtual string UlogaUPublikaciji { get; set; }

        public AutorstvoView(Autorstvo a)
        {
            ID_U = new AutorView( a.ID_U);
            ID_P = new PublikacijaView( a.ID_P);
            RedniBrojAutora = a.RedniBrojAutora;
            TipDoprinosa = a.TipDoprinosa;
            UlogaUPublikaciji = a.UlogaUPublikaciji;
        }
    }
}
