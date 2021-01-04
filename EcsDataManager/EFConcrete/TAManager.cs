using EcsDataManager.Data;
using EcsDataManager.EFContracts;
using EcsDataManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFConcrete
{
    public class TAManager : ICRUDManager<Coordinators>, IUpdateComment<Coordinators>
    {
        private readonly ApplicationDbContext _dbContext;

        public TAManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Add(Coordinators entity, short ismain = 0)
        {
            _dbContext.Coordinators.Add(entity);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Change(Coordinators dbEntity, Coordinators entity)
        {
            dbEntity.AHDTracker = entity.AHDTracker;
            dbEntity.Mobile = entity.Mobile;
            dbEntity.TaName = entity.TaName;
            dbEntity.Tell = entity.Tell;

            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> ChangeComment(Coordinators dbEntity, Coordinators entity)
        {
            dbEntity.Comment = entity.Comment;
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public async Task<int> Delete(Coordinators entity)
        {
            _dbContext.Coordinators.Remove(entity);
            var res = await _dbContext.SaveChangesAsync();
            return res;
        }

        public Task<Coordinators> Get(int id, short ismain = 0)
        {
            var res = Task.FromResult(_dbContext.Coordinators
                     .FirstOrDefault(e => e.Id == id));
            return res;
        }

        public Task<List<Coordinators>> GetAll(short ismain = 0)
        {
            var res = Task.FromResult(_dbContext.Coordinators.OrderByDescending(x => x.Id).ToList());
            return res;
        }
    }
}
