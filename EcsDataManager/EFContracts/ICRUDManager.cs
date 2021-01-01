using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface ICRUDManager<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> Get(int id);
        void Add(TEntity entity);
        void Change(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
