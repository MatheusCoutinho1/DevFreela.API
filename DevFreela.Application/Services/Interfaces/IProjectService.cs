// Classe que descreve o que um serviço relacionado a projetos pode fazer no programa.
// Essa classe garante que os serviços que a implementam sigam essas tarefas, tornando a programação mais organizada e consistente.

using DevFreela.Application.inputModel;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Services.Interfaces
{
    // Todas as funcionalidades do projectController representadas no projectService.
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll (string query);
        ProjectDetailsViewModel GetById(int id);
        int Create(NewProjectInputModel intputModel);
        void Update(UpdateProjectInputModel inputModel);
        void Delete(int id);
        void CreateComment(CreateCommentInputModel inputModel);
        void Start(int id);
        void Finish(int id);
    }
}
