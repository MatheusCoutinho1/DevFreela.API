// Ponto de entrada para acessar os dados em um banco de dados. Ela também fornece dados de exemplo para fins de desenvolvimento e teste.
// No entanto, em um aplicativo real, esses dados fictícios geralmente seriam substituídos por dados reais armazenados em um banco de dados,
// e métodos para acessar e manipular esses dados seriam implementados nesta classe.
using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        // Criação de litas de novos usuários, projetos e skills, através de construtores que foram implementados na camada core.
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project ("Meu projeto ASPNET Core 1 ", "Minha descrição de projeto 1 ", 1, 1, 10000),
                new Project ("Meu projeto ASPNET Core 2 ", "Minha descrição de projeto 2 ", 1, 1, 20000),
                new Project ("Meu projeto ASPNET Core 3 ", "Minha descrição de projeto 3 ", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Matheus Coutinho", "matheuscoutinho@gmail.com.br", new DateTime(2001, 1, 1)),
                new User("Luis Felipe", "luisfelipe@gmail.com.br", new DateTime(1992, 1, 1)),
                new User("Anderson", "anderson@gmail.com.br", new DateTime(1998, 1, 1))
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }

        // Lista Criadas através das referências que foram criadas na pasta Entities no camada Core.
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
