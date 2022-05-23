using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Az204WebApp.Pages
{
    public class ConfigurationPropertiesModel : PageModel
    {
        public ConfigurationPropertiesModel(IConfiguration _config)
        {
            Config = _config;
        }

        public IConfiguration Config { get; }

        public void OnGet()
        {
        }
    }
}
