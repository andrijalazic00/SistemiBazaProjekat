namespace datalibrary.Entiteti
{
public class IstrazivackiRezultati
{
        public virtual int Id { get; protected set; }
        public virtual string Naslov { get; set; }
        public virtual string Apstrakt { get; set; }
        public virtual DateOnly DatumKreiranja { get; set; }
        public virtual DateOnly DatumObjavljivanja { get; set; }
        public virtual string StatusIR { get; set; }
        public virtual bool Vidljivost { get; set; }   

        public IstrazivackiRezultati()
        {
            
        } 
}

}