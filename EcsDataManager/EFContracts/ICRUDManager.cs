using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface ICRUDManager<TEntityDto, TEntityViewDto, TId> 
    {
        Task Add(TEntityDto dto);
        Task Update(TEntityDto dto);
        Task Delete(TId id);
        List<TEntityViewDto> GetAll(int currentPage, int rowPerPage, string search);
        TEntityDto Get(TId id);
    }
}
