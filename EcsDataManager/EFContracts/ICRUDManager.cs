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
        Task Add(TEntity entity);
        Task Change(TEntity dbEntity, TEntity entity);
        Task Delete(TEntity entity);
    }
}
