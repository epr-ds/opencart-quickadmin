using REST.Responses;
using RestEase;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace REST
{
    [Header("User-Agent", "OCQuickAdmin")]
    [BasePath("index.php?route=api/{resource}")]
    public interface IQuickAdminApi
    {
        /// <summary>
        /// If this parameter is null, then it is not sended every request.
        /// </summary>
        [Query("api_token")]
        string Token { get; set; }

        [Path("resource")]
        string Resource { get; set; }

        [Post("/index.php?route=api/login")]
        Task<LoginResponse> Login([Body(BodySerializationMethod.Default)] MultipartContent content);

        [Post]
        Task<MessageResponse> Add<TModel>([Body] TModel model);

        [Put]
        Task<MessageResponse> Update<TModel>([Body] TModel model);

        [Delete]
        Task<MessageResponse> Delete(int id);

        [Get]
        Task<TModel> Get<TModel>(int id);

        [Get]
        Task<IEnumerable<TModel>> Get<TModel>();
        
        [Get]
        Task<IEnumerable<TModel>> Get<TModel>(int page = 1, int items = 20, string filter = null);

        [Post]
        Task<ImageResponse> Upload([Body] HttpContent content);
    }
}
