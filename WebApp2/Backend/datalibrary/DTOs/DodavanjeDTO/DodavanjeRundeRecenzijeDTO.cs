using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeRundeRecenzijeDTO
    {
        public virtual int ID_Recenzenta { get; set; }
        public virtual int ID_Urednika { get; set; }
        public virtual int ID_Publikacija { get; set; }
        public virtual int BrojRunde { get; set; }
        public virtual string Preporuka {get; set;}
        public virtual DateTime DatumOdluke { get; set; }
        public virtual string KonacnaOdluka { get; set; }

    }
}