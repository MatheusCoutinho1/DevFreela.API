// Informações necessárias para cadastrar um projeto no dbContext

namespace DevFreela.Application.inputModel
{
    public class NewProjectInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int IdClient { get; set; }
        public int IdFreelancer { get; set; }
        public decimal TotalCost { get; set; }

    }
}
