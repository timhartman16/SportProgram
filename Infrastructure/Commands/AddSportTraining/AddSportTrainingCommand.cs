using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddSportTraining
{
    public class AddSportTrainingCommand
    {
        public string Title { get; }

        public AddSportTrainingCommand(string title)
        {
            Title = title;
        }
    }
}
