using REST;
using RestEase;

namespace WinForms.Cache
{
    internal static class ApiManager
    {
        public static string Token { get; set; }

        public static IQuickAdminApi API 
        { 
            get
            {
                IQuickAdminApi api;
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

                return api;
            }
        }
    }
}
