// Uma habilidade poderá ser aplicada a vários usuários e um usuário poderá ter várias habilidades, relacionamento de N para N
// Entidade criada para mapear o relacionamento de N para N 

namespace DevFreela.Core.Entities
{
    // UserSkill vai herdar BaseEnity para usar o ID que foi criado para ser reutilizado em outras partes da aplicação.
    public class UserSkill : BaseEntity
    {
        // Contrutor criado para realizar o mapeamento das habilidades, pois o private set só permitem alterações através dos contrutores.
        public UserSkill(int idUser, int idSkill)
        {
            IdUser = idUser;
            IdSkill = idSkill;
        }
        // Propriedades criadas para mapear uma habilidade para um usuário.
        public int IdUser { get; private set; }
        public int IdSkill { get; private set; }
        public Skill Skill { get; private set; }
    }
    
    // Private set é usada para melhorar o encapsulamento da aplicação.
    // As informações não poderam ser alteradas fora do escopo dessa classe.
}
