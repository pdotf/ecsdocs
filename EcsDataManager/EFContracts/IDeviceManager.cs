using System.Threading.Tasks;

namespace EcsDataManager.EFContracts
{
    public interface IDeviceManager<T>
    {
        Task<T> GetDevice(int id, short ismain = 0);
    }
}