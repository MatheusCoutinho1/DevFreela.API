using DevFreela.Application.Commands.CreateProject;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using DevFreela.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddScoped<DevFreelaDbContext>();

            var connectionString = builder.Configuration.GetConnectionString("DevFreelaCs");
            builder.Services.AddDbContext<DevFreelaDbContext>(p => p.UseSqlServer(connectionString));

            builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ISkillRepository, SkillRepository>();

            builder.Services.AddControllers();

            builder.Services.AddMediatR((typeof(CreateProjectCommand).Assembly));


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }

    //builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = A mesma instância será chamada por todo aplicativo.

    //builder.Services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = uma instância por requisição.

    //builder.Services.AddTransient<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = Uma instância por classe.

}