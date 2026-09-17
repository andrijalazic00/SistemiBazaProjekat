using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class KljucnaRecView
    {
        public virtual IstrazivackiRezultatView ID_IR { get; set; }
        public virtual string Rec { get; set; }


        public KljucnaRecView(KljucnaRec k)
        {
            ID_IR = new IstrazivackiRezultatView(k.ID_IR);
            Rec = k.Rec;
        }
    }
}
