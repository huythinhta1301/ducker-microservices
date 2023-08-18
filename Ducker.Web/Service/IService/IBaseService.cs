using Ducker.Web.Models;

namespace Ducker.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDTO> SendAsync (RequestDTO requestDTO);
    }
}
