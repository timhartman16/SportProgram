using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.DeleteSportTraining
{
    public class DeleteSportTrainingCommand
    {
        public Guid Id { get; set; }

        public DeleteSportTrainingCommand(Guid id)
        {
            Id = id;
        }
    }
}
