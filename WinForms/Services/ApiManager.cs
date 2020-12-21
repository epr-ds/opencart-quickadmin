using REST;
using RestEase;
using System;
using System.Net.Http;
using WinForms.Cache;

namespace WinForms.Services
{
    internal static class ApiManager
    {
        public static string Token { get; set; }

        public static IQuickAdminApi API 
        {
            get
            {
                IQuickAdminApi api;

#if DEBUG
                var httpClient = new HttpClient(new ApiLogger())
                {
                    BaseAddress = new Uri(Properties.Settings.Default.api_url),
                    Timeout = TimeSpan.FromSeconds(10), // Very slow to respond, this server
                };

                api = RestClient.For<IQuickAdminApi>(httpClient);
                api.Token = Token;
#else
                if (Properties.Settings.Default.useCache)
                {
                    api = new CacheableApi(Properties.Settings.Default.api_url)
                    {
                        Token = Token
                    };
                }
                else
                {
                    api = RestClient.For<IQuickAdminApi>(Properties.Settings.Default.api_url);
                    api.Token = Token;
                }
#endif
                return api;
            }
        }
    }
}
