using Domain.SportTrainingAggregate;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.EditSportTraining
{
    public class EditSportTrainingCommandHandler : IHandle<EditSportTrainingCommand, SportTrainingDto>
    {
        private readonly ISportTrainingRepository _repo;

        public EditSportTrainingCommandHandler(ISportTrainingRepository repo)
        {
            _repo = repo;
        }

        public SportTrainingDto Handle(EditSportTrainingCommand command)
        {
            var findTraining = _repo.GetById(command.Id);
            if (findTraining != null)
            {
                findTraining.EditSportTraining(command.Title);
            }
            _repo.Save();
            return new SportTrainingDto()
            {
                Id = findTraining.Id,
                Title = findTraining.Title,
            };
        }
    }
}
