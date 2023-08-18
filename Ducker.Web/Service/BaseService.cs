using Ducker.Web.Models;
using Ducker.Web.Service.IService;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using static Ducker.Web.Utility.DataHelper;

namespace Ducker.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory; 
        }

        public async Task<ResponseDTO?> SendAsync(RequestDTO requestDTO)
        {
            HttpClient client = _httpClientFactory.CreateClient("DuckerAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");

            message.RequestUri = new Uri(requestDTO.Url);
            if(requestDTO.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(requestDTO.Data),Encoding.UTF8, "application/json");
            }

            HttpResponseMessage? apiResponse = null;
            
            switch(requestDTO.ApiType)
            {
                case ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                case ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                     break;
                default:
                    message.Method = HttpMethod.Get;
                     break;
            }
            apiResponse = await client.SendAsync(message);

            switch(apiResponse.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    return new() { IsSuccess = false, Message = "Not found" };
                case HttpStatusCode.Forbidden:
                    return new() { IsSuccess = false, Message = "Not found" };
                case HttpStatusCode.Unauthorized:
                    return new() { IsSuccess = false, Message = "Not found" };
                case HttpStatusCode.InternalServerError:
                    return new() { IsSuccess = false, Message = "Internal Server Error" };
            }

            return null;
        }
    }
}
