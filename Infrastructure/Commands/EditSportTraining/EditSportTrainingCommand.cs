using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.EditSportTraining
{
    public class EditSportTrainingCommand 
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public EditSportTrainingCommand(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
