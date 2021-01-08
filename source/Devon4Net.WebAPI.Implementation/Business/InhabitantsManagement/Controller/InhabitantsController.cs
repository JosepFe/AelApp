using System.Threading.Tasks;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Controller
{
    /// <summary>
    /// Inhabitants controller
    /// </summary>
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class InhabitantsController : ControllerBase
    {
        private readonly IInhabitantsService _inhabitantsService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="todoService"></param>
        public InhabitantsController(IInhabitantsService inhabitantsService)
        {
            _inhabitantsService = inhabitantsService;
        }
        
        /// <summary>
        /// Creates a User
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("createuser")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var user = await _inhabitantsService.CreateUser(createUserDto.Name, createUserDto.Surname, createUserDto.Dni);

            Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
            return StatusCode(StatusCodes.Status201Created, user);
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("deleteuser")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteUser([FromBody] DeleteUserDto deleteUserDto)
        {
            await _inhabitantsService.DeleteUser(deleteUserDto.Name, deleteUserDto.Surname);

            Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Register a User in town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("registerusertown")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> RegisterUserTown(string name, string surname, string townName)
        {
            var a = await _inhabitantsService.RegisterUserTown(name, surname, townName);

            Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
            return StatusCode(StatusCodes.Status201Created, a);
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("userbelongstown")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UserBelongsTown(string name, string surname, string townName)
        {
            var a = await _inhabitantsService.CheckUserBelongsTown(name, surname, townName);

            Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
            return StatusCode(StatusCodes.Status201Created, a);
        }
    }
}
