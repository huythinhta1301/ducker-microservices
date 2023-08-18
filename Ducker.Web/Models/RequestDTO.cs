using static Ducker.Web.Utility.DataHelper;

namespace Ducker.Web.Models
{
    public class RequestDTO
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public string Data { get; set; }
        public string AccessToken { get; set; }
    }
}
