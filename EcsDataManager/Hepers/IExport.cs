using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcsDataManager.Hepers
{
    public interface IExport
    {
        Task CsvExport<T>(List<T> records);
    }
}