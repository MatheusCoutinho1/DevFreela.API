// Classe criada para mostrar as informações de cada usuário.

namespace DevFreela.Core.Entities
{
    // User herdará BaseEntity para acessar o ID que foi criado para ser reuilizado em outras classes.
    internal class User : BaseEntity
    {
        // Contrutor criado para que quando um usuário novo for criado, ele passe o nome completo, email e data de nascimento.
        // Demais campos serão atualizados diretamente, sem precisar serem preenchidos.
        public User(string fullName, string email, DateTime birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            CreatedAt = DateTime.Now;
            Skills = new List<UserSkill>();
            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        // Propriedade que define o nome completo dos usuários.
        public string FullName { get; private set; }

        // Propriedade que define o email dos usuários.
        public string Email { get; private set; }

        // Propriedade que define o a data de nascimento dos usuários.
        public DateTime BirthDate { get; private set; }

        // Propriedade que define a data que o usuário foi criado.
        public DateTime CreatedAt { get; private set; }

        // Propriedade que define se o usuário está ativo ou não.
        public bool Active { get; private set; }


        // Propriedade que define a lista de habilidades de cada usuário.
        public List<UserSkill> Skills { get; private set; }

        // Propriedade que define a lista de projetos de cada usuário.
        public List<Project> OwnedProjects { get; private set; }

        // Propriedade que define a lista de projetos de cada usuário, em projetos que ele atuou como freelancer.
        public List<Project> FreelanceProjects { get; private set; }
    }

    // Private set é usada para melhorar o encapsulamento da aplicação.
    // As informações não poderam ser alteradas fora do escopo dessa classe.
}
