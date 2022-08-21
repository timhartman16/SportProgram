using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands.AddSportTraining
{
    public class AddSportTrainingCommand
    {
        public string Title { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public AddSportTrainingCommand(string title, Guid userId, string userName)
        {
            Title = title;
            UserId = userId;
            UserName = userName;
        }
    }
}
