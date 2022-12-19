namespace AutoOABlazor.Client.Services
{
    public abstract class BaseService
    {
        protected readonly HttpClient Client;

        public BaseService(HttpClient httpClient)
        {
            Client = httpClient;
        }
    }
}