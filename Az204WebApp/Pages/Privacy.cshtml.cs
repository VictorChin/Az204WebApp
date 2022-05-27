using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;

namespace Az204WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly IDistributedCache cache;
        public string CachedData;

        public PrivacyModel(ILogger<PrivacyModel> logger, IDistributedCache _cache)
        {
            _logger = logger;
            cache = _cache;
        }

        public void OnGet()
        {
            CachedData = cache.GetString("key1");
        }
    }
}