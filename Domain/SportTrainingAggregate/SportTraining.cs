using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SportTrainingAggregate
{
    public class SportTraining
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        private SportTraining()
        {

        }

        public SportTraining(Guid sportTriningId, string title)
        {
            Id = sportTriningId;
            Title = title;
        }

        public void EditSportTraining(string title)
        {
            Title = title;
        }
    }
}
