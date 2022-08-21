using AutoMapper;
using Domain.SportTrainingAggregate;
using Infrastructure.DTO;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Queries.GetByIdSportTraining
{
    public class GetByIdSportTrainingQuery : IGetByIdSportTrainingQuery
    {
        private readonly ISportTrainingRepository _repo;
        private readonly IMapper _mapper;

        public GetByIdSportTrainingQuery(ISportTrainingRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public SportTrainingDto Execute(GetByIdSportTrainingFilter criteria)
        {
            var result = _repo.GetById(criteria.Id);
            return _mapper.Map<SportTrainingDto>(result);
        }

    }
}
