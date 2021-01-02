using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface ICRUDManager<TEntity>
    {
        Task<List<TEntity>> GetAll(short ismain=0);
        Task<TEntity> Get(int id,short ismain=0);
        Task<int> Add(TEntity entity,short ismain=0);
        Task<int> Change(TEntity dbEntity, TEntity entity);
        Task<int> Delete(TEntity entity);
    }
}
