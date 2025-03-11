using DEVSECOPS.API.Models;

namespace DEVSECOPS.API.HttpClients
{
    public class BeansClient
    {
        private readonly HttpClient _httpClient;
        string urlBase = "https://jellybellywikiapi.onrender.com/api/Beans";

        public BeansClient( HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<BeanModel> GetBeanById(int BeanId)
        {
            HttpResponseMessage response  = await _httpClient.GetAsync($"{urlBase}/{BeanId}");

            if (!response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return null;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    throw new HttpRequestException("Bad request", null, System.Net.HttpStatusCode.BadRequest);
                }
                else
                {
                    throw new HttpRequestException($"Http request failed with status code {response.StatusCode}");
                }
            }

            BeanModel? responsemodel = await response.Content.ReadFromJsonAsync<BeanModel>();

            //if (responsemodel == null)
            //{
            //    throw new ArgumentException("Invalid User ID");
            //}

            return responsemodel;
        }
    }
}
