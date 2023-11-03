using DevFreela.API.Models;

namespace DevFreela.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));

            builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

            builder.Services.AddControllers();
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

    //builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = A mesma inst�ncia ser� chamada por todo aplicativo.

    //builder.Services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = uma inst�ncia por requisi��o.

    //builder.Services.AddTransient<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" }); = Uma inst�ncia por classe.

}