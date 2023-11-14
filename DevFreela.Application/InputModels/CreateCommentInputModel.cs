// Informações necessárias para cadastrar um comentário.

namespace DevFreela.Application.inputModel
{
    public class CreateCommentInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
