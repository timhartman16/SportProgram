using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllSportTraining
{
    public interface IGetAllSportTrainingQuery : IQuery<IEnumerable<SportTrainingDto>>
    {
    }
}
