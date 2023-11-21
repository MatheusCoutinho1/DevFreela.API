// Classe criada para armazenar as informações dos comentários do projeto.

namespace DevFreela.Core.Entities
{
    // ProjectComment vai herdar BaseEnity para usar o ID que foi criado para ser reutilizado em outras partes da aplicação
    public class ProjectComment : BaseEntity
    {
        // Contrutor criado com as informações que serão passadas pelos usuários.
        public ProjectComment(string content, int idProject, int idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;
        }

        // Define o conteúdo dos comentários.
        public string Content { get; private set; }

        // Define o indentficador do projeto.
        public int IdProject { get; private set; }
        public Project Project { get; private set; }

        // Define o ID do usuário que compartilhou o comentário.
        public int IdUser { get; private set; }
        public User User { get; private set; }

        // Define a data de criação do comentário.
        public DateTime CreatedAt { get; private set; }
    }
}
