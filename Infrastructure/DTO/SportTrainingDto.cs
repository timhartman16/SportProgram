using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DTO
{
    public class SportTrainingDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
    }
}
