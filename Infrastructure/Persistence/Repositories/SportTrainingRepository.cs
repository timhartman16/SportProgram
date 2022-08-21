using Domain.SportTrainingAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public class SportTrainingRepository : ISportTrainingRepository
    {
        private readonly SportProgramDbContext _db;

        public SportTrainingRepository(SportProgramDbContext db)
        {
            _db = db;
        }
        public IEnumerable<SportTraining> GetAll()
        {
            return _db.SportTraining.ToList();
        }

        public SportTraining GetById(Guid id)
        {
            return _db.SportTraining.FirstOrDefault(x => x.Id == id);
        }

        public void Create(SportTraining item)
        {
            _db.SportTraining.Add(item);
        }

        public void Delete(Guid id)
        {
            var sportTraining = _db.SportTraining.FirstOrDefault(x => x.Id == id);
            if (sportTraining != null)
                _db.SportTraining.Remove(sportTraining);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
