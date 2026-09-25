using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class OstaliDokumentiView : IstrazivackiRezultatView
    {
        public virtual string Opcije { get; set; }

        public OstaliDokumentiView(OstaliDokumenti o) : base(o)
        {
            Opcije = o.Opcije;
        }
    }
}
