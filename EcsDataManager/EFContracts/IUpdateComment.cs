using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface IUpdateComment<TEntity>
    {
        Task ChangeComment(TEntity dbEntity, TEntity entity);
    }
}
