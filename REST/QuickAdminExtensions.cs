using REST.Responses;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace REST
{
    public static class QuickAdminExtensions
    {
        public static Task<LoginResponse> Login(this IQuickAdminApi api, string username, string key)
        {
            var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(key), "key" }
            };

            api.Token = string.Empty;

            return api.Login(content);
        }

        public static async Task<ImageResponse> Upload(this IQuickAdminApi api, string filename)
        {
            var content = new MultipartFormDataContent();
            var imageContent = new ByteArrayContent(File.ReadAllBytes(filename));

            imageContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
            imageContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "file",
                FileName = $"\"{Path.GetFileName(filename)}\""
            };

            content.Add(imageContent);

            return await api.Upload(content);
        }
    }
}
