// Classe criada para armazenar as propriedades dos projetos.

using DevFreela.Core.Enums;

namespace DevFreela.Core.Entities
{
    // Project vai herdar BaseEnity para usar o ID que foi criado para ser reutilizado em outras partes da aplicação
    public class Project : BaseEntity
    {
        // Contrutor criado com as informações que serão passadas pelos usuários.
        // Demais campos serão atualizados diretamente, sem precisar serem preenchidos. 
        public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<ProjectComment>();
        }

        // Propriedade que define o título do projeto.
        public string Title { get; private set; }

        // Propriedade que define a descrição de cada projeto.
        public string Description { get; private set; }

        // Propriedade que define a identificação do cliente.
        public int IdClient { get; private set; }

        // Propriedade que define a identificação do Freelancer.
        public int IdFreelancer { get; private set; }

        // Propriedade que define o custo total do projeto.
        public decimal TotalCost { get;  private set; }

        // Propriedade que define a data de cadastro do projeto.
        public DateTime CreatedAt { get; private set; }

        // Propriedade que define a data de início do projeto.
        // OBS: Colocamos a interrogação após o datetime, pois esse valor não é defino na criação do projeto.
        public DateTime? StartedAt { get; private set; }

        // Propriedade que define a data do fim do projeto.
        public DateTime FinishedAt { get; private set; }

        // Propriedade que define o status do projeto.
        public ProjectStatusEnum Status { get; private set; }

        // Propriedade que define uma lista de comentários do projeto.
        public List<ProjectComment> Comments { get; private set; }

    }

    // Private set é usada para melhorar o encapsulamento da aplicação.
    // As informações não poderam ser alteradas fora do escopo dessa classe.
}
