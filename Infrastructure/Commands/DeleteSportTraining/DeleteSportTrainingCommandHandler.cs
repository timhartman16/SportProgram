using Domain.SportTrainingAggregate;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteSportTraining
{
    public class DeleteSportTrainingCommandHandler : IHandle<DeleteSportTrainingCommand>
    {
        private readonly ISportTrainingRepository _repo;

        public DeleteSportTrainingCommandHandler(ISportTrainingRepository repo)
        {
            _repo = repo;
        }
        public void Handle(DeleteSportTrainingCommand command)
        {
            var training = _repo.GetById(command.Id);
            if (training != null)
                _repo.Delete(command.Id);
            _repo.Save();
        }
    }
}
