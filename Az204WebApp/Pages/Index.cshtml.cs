using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;

namespace Az204WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDistributedCache cache;

        public IndexModel(ILogger<IndexModel> logger,IDistributedCache _cache)
        {
            _logger = logger;
            cache = _cache;
        }

        public void OnGet()
        {
            cache.SetString("key1", DateTime.UtcNow.ToLongTimeString());
            HttpContext.Session.SetString("key2", "Hello World");
            HttpContext.Session.SetInt32("key3", 73);
        }
    }
}