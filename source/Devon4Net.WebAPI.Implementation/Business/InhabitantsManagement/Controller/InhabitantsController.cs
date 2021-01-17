using System;
using System.Threading.Tasks;
using Devon4Net.Infrastructure.Log;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Exceptions;
using Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Services;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ArgumentException), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(UserAlreadyExistException), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            Devon4NetLogger.Debug("Executing CreateUser from controller InhabitantsController");
            var user = await _inhabitantsService.CreateUser(createUserDto.Name.ToLower(), createUserDto.Surname.ToLower(), createUserDto.Dni).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created, user);
        }

        /// <summary>
        /// Delete a User
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Route("deleteuser")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ArgumentException), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteUser(string name, string surname)
        {
            Devon4NetLogger.Debug("Executing DeleteUser from controller InhabitantsController");
            await _inhabitantsService.DeleteUser(name.ToLower(), surname.ToLower()).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Register a User in town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("registerusertown")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ArgumentException), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> RegisterUserTown([FromBody] RegisterUserTownDto registerUserTownDto)
        {
            Devon4NetLogger.Debug("Executing RegisterUserTown from controller InhabitantsController");
            await _inhabitantsService.RegisterUserTown(registerUserTownDto.Name.ToLower(), registerUserTownDto.Surname.ToLower(), registerUserTownDto.TownName.ToLower(), registerUserTownDto.Adress).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Check if user belongs to a town
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("userbelongstown")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UserBelongsTown([FromBody] UserBelongTownDto userBelongTownDto)
        {
            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            await _inhabitantsService.CheckUserBelongsTown(userBelongTownDto.Name.ToLower(), userBelongTownDto.Surname.ToLower(), userBelongTownDto.TownName.ToLower()).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Assig a tax to a user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("asigntaxuser")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(UserTaxAlreadyAssignedException), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> AsignTaxToUser([FromBody] AsignTaxToUserDto asignTaxToUserDto)
        {
            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            await _inhabitantsService.AssignTaxToUser(asignTaxToUserDto.Name.ToLower(), asignTaxToUserDto.Surname.ToLower(), asignTaxToUserDto.TaxName.ToLower(), asignTaxToUserDto.TaxYear, asignTaxToUserDto.BaseAmount, asignTaxToUserDto.Reference.ToLower(), asignTaxToUserDto.TownName.ToLower()).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created);
        }

        /// <summary>
        /// Payment of a tax for a user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("paytaxuser")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ArgumentException), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(UserTaxPaymentExpiredException), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PayTaxToUser([FromBody] PayTaxToUserDto payTaxToUserDto)
        {
            Devon4NetLogger.Debug("Executing CheckUserBelongsTown from controller InhabitantsController");
            await _inhabitantsService.PayTax(payTaxToUserDto.Name.ToLower(), payTaxToUserDto.Surname.ToLower(), payTaxToUserDto.TaxName.ToLower(), payTaxToUserDto.TaxYear, payTaxToUserDto.Reference.ToLower()).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status200OK);
        }

        /// <summary>
        /// Get the most updated info about which taxes has the user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getupdatedtaxuserinfo")]
        [Authorize]
        [ProducesResponseType(typeof(UserTaxInformationDto),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ArgumentException), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(AelNotFoundException), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetUpdatedTaxUserInfo(string name, string surname)
        {
            Devon4NetLogger.Debug("Executing GetTaxUserInfo from controller InhabitantsController");
            var userTaxInformation = await _inhabitantsService.GetUpdatedTaxesForUser(name.ToLower(), surname.ToLower()).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status200OK, userTaxInformation);
        }
    }
}
