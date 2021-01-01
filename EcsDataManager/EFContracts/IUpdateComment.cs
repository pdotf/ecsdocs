using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface IUpdateComment<TEntity>
    {
        void ChangeComment(TEntity dbEntity, TEntity entity);
    }
}
