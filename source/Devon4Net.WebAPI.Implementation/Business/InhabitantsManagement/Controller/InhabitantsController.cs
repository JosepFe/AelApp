using System.Threading.Tasks;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Controller
{
    /// <summary>
    /// TODOs controller
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


        ///// <summary>
        ///// Gets the entire list of TODOS
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[ProducesResponseType(typeof(List<TodoDto>), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<ActionResult> GetTodo()
        //{
        //    Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
        //    return Ok(await _todoService.GetTodo().ConfigureAwait(false));
        //}

        /// <summary>
        /// Creates a User
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateUser(string todoDescription)
        {
            var a = await _inhabitantsService.CreateUser("plazaMayor");

            Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
            return StatusCode(StatusCodes.Status201Created, a);
        }

        ///// <summary>
        ///// Deletes the TODO provided the id
        ///// </summary>
        ///// <returns></returns>
        //[HttpDelete]
        //[ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<ActionResult> Delete(long todoId)
        //{
        //    Devon4NetLogger.Debug("Executing GetTodo from controller TodoController");
        //    return Ok(await _todoService.DeleteTodoById(todoId).ConfigureAwait(false));
        //}

        ///// <summary>
        ///// Modifies the done status of the TODO provided the id
        ///// </summary>
        ///// <returns></returns>
        //[HttpPut]
        //[ProducesResponseType(typeof(TodoDto), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //[HttpOptions]
        //public async Task<ActionResult> ModifyTodo(long todoId)
        //{
        //    Devon4NetLogger.Debug("Executing ModifyTodo from controller TodoController");
        //    return Ok(await _todoService.ModifyTodoById(todoId).ConfigureAwait(false));
        //}
    }
}
