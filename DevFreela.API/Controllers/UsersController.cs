using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

// Para cadastrar os pontos de acesso dos usuários.
namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

        public UsersController(ExampleClass exampleClass) 
        { 
            
        }
        // api/users/1
        // Método para consultar um usuário.
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        //api/users
        // Método para cadastrar um novo usuário.
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        //Método para realiar o login do usuário.
        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int Id, [FromBody] LoginModel loginModel)
        {
            return NoContent();
        }
    }
}
