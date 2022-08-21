using Infrastructure.Commands;
using Infrastructure.Commands.AddSportTraining;
using Infrastructure.Commands.DeleteSportTraining;
using Infrastructure.Commands.EditSportTraining;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using Infrastructure.Queries.GetAllSportTraining;
using Infrastructure.Queries.GetByIdSportTraining;
using Infrastructure.Queries.GetCurrentUser;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace SportProgram.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SportTrainingController : ControllerBase
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IGetByIdSportTrainingQuery _getByIdSportTrainingQuery;
        private readonly IGetAllSportTrainingQuery _getAllSportTrainingQuery;
        private readonly IGetCurrentUserQuery _getCurrentUserQuery;

        public SportTrainingController(ICommandDispatcher commandDispatcher, IGetByIdSportTrainingQuery getByiIdSportTrainingQuery,
                                       IGetAllSportTrainingQuery getAllSportTrainingQuery, IGetCurrentUserQuery getCurrentUserQuery)
        {
            _commandDispatcher = commandDispatcher;
            _getByIdSportTrainingQuery = getByiIdSportTrainingQuery;
            _getAllSportTrainingQuery = getAllSportTrainingQuery;
            _getCurrentUserQuery = getCurrentUserQuery;
        }

        [HttpGet]
        [Route("GetAllSportTraining")]
        [ProducesResponseType(typeof(IEnumerable<SportTrainingDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var rez = _getAllSportTrainingQuery.Execute();
            return Ok(rez);
        }

        [HttpGet]
        [Route("GetByIdSportTraining/{id}")]
        [ProducesResponseType(typeof(SportTrainingDto), (int)HttpStatusCode.OK)]
        public IActionResult GetById(Guid id)
        {
            var filter = new GetByIdSportTrainingFilter(id);
            var rez = _getByIdSportTrainingQuery.Execute(filter);
            return Ok(rez); 
        }

        [HttpPost]
        [Route("CreateSportTraining")]
        [ProducesResponseType(typeof(SportTrainingIdDto), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Create(AddSportTrainingDto sportTraining)
        {
            var filter = new GetCurrentUserFilter(HttpContext.User);
            var user = await _getCurrentUserQuery.ExecuteAsync(filter);

            var command = new AddSportTrainingCommand(sportTraining.Title, user.Id, user.UserName);
            var result = _commandDispatcher.Handle<AddSportTrainingCommand, SportTrainingIdDto>(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("EditSportTraining/{id}")]
        [ProducesResponseType(typeof(SportTrainingDto), (int)HttpStatusCode.OK)]
        public IActionResult Edit(EditSportTrainingDto sportTraining)
        {
            var command = new EditSportTrainingCommand(sportTraining.Id, sportTraining.Title);
            var result = _commandDispatcher.Handle<EditSportTrainingCommand, SportTrainingDto>(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteSportTraining/{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(Guid id)
        {
            var command = new DeleteSportTrainingCommand(id);
            _commandDispatcher.Handle(command);
            return Ok();
        }
    }
}
