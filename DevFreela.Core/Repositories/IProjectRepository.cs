// O Repository Pattern é um padrão de arquitetura de software que separa a lógica de acesso a dados
// (como banco de dados, serviço da web, armazenamento em arquivo, etc.) do restante do código do aplicativo.

using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetDetailsByIdAsync(int id);
        Task<Project> GetByIdAsync(int id);
        Task AddAsync(Project project);
        Task StartAsync(Project project);
        Task AddCommentAsync(ProjectComment projectComment);
        Task SaveChangesAsync();
    }
}
