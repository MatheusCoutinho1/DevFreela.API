// Classe criada para mostrar a série de habilidades de cada usuário.

namespace DevFreela.Core.Entities
{
    // Skill vai herdar BaseEnity para usar o ID que foi criado para ser reutilizado em outras partes da aplicação.
    public class Skill : BaseEntity
    {
        // Construtor recebendo atribuindo os métodos criados.
        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        //Propriedade para mostrar as habilidades e descrição de cada usuário.
        public string Description { get; private set; }

        // Propriedade que indica quando foi criado.
        public DateTime CreatedAt { get; private set; }
    }

    // Private set é usada para melhorar o encapsulamento da aplicação.
    // As informações não poderam ser alteradas fora do escopo dessa classe.
}
