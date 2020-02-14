using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace AxesSharp
{
    public class ApiClient
    {
        public async Task<T> Get<T>(string url) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Get<T>(string url, string token) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", string.Format("Bearer {0}", token));
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Post<T>(string url, object body) where T: new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Post<T>(string url, object body, string token) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            request.AddHeader("Authorization", string.Format("Bearer {0}", token));
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Put<T>(string url, object body) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Put<T>(string url, object body, string token) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            request.AddHeader("Authorization", string.Format("Bearer {0}", token));
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Delete<T>(string url, object body) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }

        public async Task<T> Delete<T>(string url, object body, string token) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
            request.AddHeader("Authorization", string.Format("Bearer {0}", token));
            var response = await client.ExecuteAsync<T>(request);
            return response.Data;
        }
    }
}
