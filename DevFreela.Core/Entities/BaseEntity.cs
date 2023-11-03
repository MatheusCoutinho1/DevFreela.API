namespace DevFreela.Core.Entities
{
    //Uma entidade base, uma clase abstrata que não pode ser instânciada diretamente. 
    //Uma classe para conter informações que serão reutilizadas por diferentes partes e diferente classes.
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        public int Id { get; private set; }
    }
}
