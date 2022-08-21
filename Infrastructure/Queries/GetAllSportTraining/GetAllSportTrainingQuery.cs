using AutoMapper;
using Domain.SportTrainingAggregate;
using Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetAllSportTraining
{
    public class GetAllSportTrainingQuery : IGetAllSportTrainingQuery
    {
        private readonly ISportTrainingRepository _repo;
        private readonly IMapper _mapper;

        public GetAllSportTrainingQuery(ISportTrainingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<SportTrainingDto> Execute()
        {
            var sportTrainings = _repo.GetAll().ToList();
            return _mapper.Map<IEnumerable<SportTrainingDto>>(sportTrainings);
        }
    }
}
