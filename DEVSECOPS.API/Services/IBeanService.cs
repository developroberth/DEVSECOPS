using DEVSECOPS.API.Models;

namespace DEVSECOPS.API.Services
{
    public interface IBeanService
    {
        Task<BeanModel> GetBeanById(int BeanId);
    }
}
