using DEVSECOPS.API.HttpClients;
using DEVSECOPS.API.Models;

namespace DEVSECOPS.API.Services
{
    public class BeanService : IBeanService
    {
        private readonly BeansClient  _beansClient;
        public BeanService(BeansClient beansClient)
        {
            _beansClient = beansClient;
        }
        public Task<BeanModel> GetBeanById(int BeanId)
        {
           return _beansClient.GetBeanById(BeanId);
        }
    }
}
