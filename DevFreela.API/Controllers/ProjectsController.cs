using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.Extensions.Options;

// Funcionalidades e pontos de acesso das APIs do projeto.
namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;
        public ProjectsController(IOptions<OpeningTimeOption> option, ExampleClass exampleClass )
        {
            exampleClass.Name = "Update at ProjectsController";
            _option = option.Value;
        }
        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            // Buscar todos projetos
            return Ok();
        }

        // api/projects/599
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //Buscar um projeto específico através de um ID.
            // Caso o ID desse projeto não funcione, return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            // Cadastro o Projeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put (int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            // Atualiza o projeto

            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete( int id)
        {
            // Busca o projeto, se não existir, retorna NotFound
            // Remover

            return NoContent();
        }

        // Para cadastrar comentários.
        // api/projects/1/comments POST
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        // Método para iniciar o projeto e atualizar o status.
        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // Método para finalizar o projeto e atualizar o status.
        // api/projects/1/finish
        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
