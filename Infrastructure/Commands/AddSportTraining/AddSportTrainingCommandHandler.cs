using Domain.SportTrainingAggregate;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddSportTraining
{
    public class AddSportTrainingCommandHandler : IHandle<AddSportTrainingCommand, SportTrainingIdDto>
    {
        private readonly ISportTrainingRepository _repo;

        public AddSportTrainingCommandHandler(ISportTrainingRepository repo)
        {
            _repo = repo;
        }

        public SportTrainingIdDto Handle(AddSportTrainingCommand command)
        {
            var sportTraining = new SportTraining(Guid.NewGuid(), command.Title);
            _repo.Create(sportTraining);
            _repo.Save();
            return new SportTrainingIdDto() { Id = sportTraining.Id };
        }
    }
}
