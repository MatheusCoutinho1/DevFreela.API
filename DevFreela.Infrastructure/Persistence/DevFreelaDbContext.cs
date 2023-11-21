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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Client)
                .WithMany(f => f.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectComment>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<ProjectComment>()
                .HasOne(p => p.Project)
                .WithMany(p => p.Comments)
                .HasForeignKey(p => p.IdProject);

            modelBuilder.Entity<ProjectComment>()
               .HasOne(p => p.User)
               .WithMany(p => p.Comments)
               .HasForeignKey(p => p.IdUser);

            modelBuilder.Entity<Skill>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<User>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Skills)
                .WithOne()
                .HasForeignKey(u => u.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserSkill>()
                .HasKey(s => s.Id);
        }
    }
}
