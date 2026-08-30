using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class UredjujeView
    {
        public virtual KnjigaIliPoglavljaView ID_IR { get; set; }
        public virtual UrednikView ID_Urednika { get; set; }
        

        public UredjujeView(Uredjuje u)
        {
            ID_IR = new KnjigaIliPoglavljaView( u.ID_IR);
            ID_Urednika = new UrednikView( u.ID_Urednika);
        }
    }
}
