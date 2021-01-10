using System.Threading.Tasks;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto;
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            var user = await _inhabitantsService.CreateUser(createUserDto.Name.ToLower(), createUserDto.Surname.ToLower(), createUserDto.Dni);

            Devon4NetLogger.Debug("Executing GetTodo from controller InhabitantsController");
            return StatusCode(StatusCodes.Status201Created, user);
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("deleteuser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteUser([FromBody] DeleteUserDto deleteUserDto)
        {
            await _inhabitantsService.DeleteUser(deleteUserDto.Name.ToLower(), deleteUserDto.Surname.ToLower());

            Devon4NetLogger.Debug("Executing GetTodo from controller InhabitantsController");
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Register a User in town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("registerusertown")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> RegisterUserTown([FromBody] RegisterUserTownDto registerUserTownDto)
        {
            await _inhabitantsService.RegisterUserTown(registerUserTownDto.Name.ToLower(), registerUserTownDto.Surname.ToLower(), registerUserTownDto.TownName.ToLower(), registerUserTownDto.Adress).ConfigureAwait(false);

            Devon4NetLogger.Debug("Executing RegisterUserTown from controller InhabitantsController");
            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("userbelongstown")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UserBelongsTown([FromBody] UserBelongTownDto userBelongTownDto)
        {
            await _inhabitantsService.CheckUserBelongsTown(userBelongTownDto.Name.ToLower(), userBelongTownDto.Surname.ToLower(), userBelongTownDto.TownName.ToLower());

            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("asigntaxuser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AsignTaxToUser([FromBody] AsignTaxToUserDto asignTaxToUserDto)
        {
            await _inhabitantsService.AssignTaxToUser(asignTaxToUserDto.Name.ToLower(), asignTaxToUserDto.Surname.ToLower(), asignTaxToUserDto.TaxName.ToLower(), asignTaxToUserDto.TaxYear, asignTaxToUserDto.BaseAmount, asignTaxToUserDto.Reference.ToLower());

            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("paytaxuser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PayTaxToUser([FromBody] PayTaxToUserDto payTaxToUserDto)
        {
            await _inhabitantsService.PayTax(payTaxToUserDto.Name.ToLower(), payTaxToUserDto.Surname.ToLower(), payTaxToUserDto.TaxName.ToLower(), payTaxToUserDto.TaxYear, payTaxToUserDto.Reference.ToLower());

            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
