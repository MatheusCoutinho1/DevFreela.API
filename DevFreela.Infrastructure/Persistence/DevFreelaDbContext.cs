// Ponto de entrada para acessar os dados em um banco de dados. Ela também fornece dados de exemplo para fins de desenvolvimento e teste.
// No entanto, em um aplicativo real, esses dados fictícios geralmente seriam substituídos por dados reais armazenados em um banco de dados,
// e métodos para acessar e manipular esses dados seriam implementados nesta classe.
using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        // Criação de litas de novos usuários, projetos e skills, através de construtores que foram implementados na camada core.
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
           
        }

        // Lista Criadas através das referências que foram criadas na pasta Entities no camada Core.
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkill { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }
    }
}
