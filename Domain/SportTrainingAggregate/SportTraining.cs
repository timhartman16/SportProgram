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

        public Guid UserId { get; private set; }
        public string UserName { get; private set; }

        private SportTraining()
        {

        }

        public SportTraining(Guid sportTriningId, string title, Guid userId, string userName)
        {
            Id = sportTriningId;
            Title = title;
            UserId = userId;
            UserName = userName;
        }

        public void EditSportTraining(string title)
        {
            Title = title;
        }
    }
}
