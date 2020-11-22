using REST;
using REST.Responses;
using RestEase;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WinForms.Cache
{
    internal class CacheableApi : IQuickAdminApi
    {
        private IQuickAdminApi api;

        private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();

        public CacheableApi(string url) => api = RestClient.For<IQuickAdminApi>(url);

        public string Token { get => api.Token; set => api.Token = value; }

        public string Resource
        {
            get => api.Resource; set
            {
                api.Resource = value;
                if (!cache.ContainsKey(value) && IsCacheable(value))
                    cache.Add(value, null);
            }
        }

        public Task<MessageResponse> Add<TModel>([Body] TModel model) => api.Add(model);

        public Task<MessageResponse> Delete(int id) => api.Delete(id);

        public Task<TModel> Get<TModel>(int id) => api.Get<TModel>(id);

        public async Task<IEnumerable<TModel>> Get<TModel>()
        {
            if (!IsCacheable(api.Resource))
                return await api.Get<TModel>();

            if (cache.TryGetValue(api.Resource, out object data) && data == null)
                cache[api.Resource] = await api.Get<TModel>();

            return cache[api.Resource] as IEnumerable<TModel>;
        }

        public Task<IEnumerable<TModel>> Get<TModel>(int page = 1, int items = 20, string filter = null) => api.Get<TModel>(page, items, filter);

        public Task<LoginResponse> Login([Body(BodySerializationMethod.Default)] MultipartContent content) => api.Login(content);

        public Task<MessageResponse> Update<TModel>([Body] TModel model) => api.Update(model);

        public Task<ImageResponse> Upload([Body] HttpContent content) => api.Upload(content);

        private static bool IsCacheable(string resource)
        {
            string[] resources = new string[]
            {
                "data/paymentmethods",
                "data/shippingmethods",
                "data/zones",
                "data/countries",
                "data/customergroups",
                "data/manufacturers",
                "data/stores",
                "data/languages",
                "data/stockstatuses",
                "data/currencies",
                "data/weightclasses",
                "data/lengthclasses",
                "data/categories",
                "data/taxclasses",
                "data/orderstatuses"
            };

            return resources.Contains(resource);
        }
    }
}
