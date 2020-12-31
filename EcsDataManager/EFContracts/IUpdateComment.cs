using System;
using System.Collections.Generic;
using System.Text;

namespace EcsDataManager.EFContracts
{
    public interface IUpdateComment<TEntity>
    {
        void ChangeComment(TEntity dbEntity, TEntity entity);
    }
}
