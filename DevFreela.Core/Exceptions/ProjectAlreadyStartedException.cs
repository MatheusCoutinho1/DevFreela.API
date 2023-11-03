// Exceção criada para quando o usuário tentar inicializar um projeto que já foi inicializado.

namespace DevFreela.Core.Exceptions
{
    // A classe herda Exception para criar uma exceção personalizada que pode ser lançada em uma situação específica.
    // Prática comum ao criar exceções personalizadas.
    public class ProjectAlreadyStartedException : Exception
    {
        // base é utilizado para chamar o construtor da classe base e passar a mensagem de erro.
        public ProjectAlreadyStartedException() : base("Project is already in started status")
        {
        }
    }
}
