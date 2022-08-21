using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetByIdSportTraining
{
    public class GetByIdSportTrainingFilter
    {
        public Guid Id { get; set; }

        public GetByIdSportTrainingFilter(Guid id)
        {
            Id = id;
        }
    }
}
