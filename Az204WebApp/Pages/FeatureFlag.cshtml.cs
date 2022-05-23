using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace Az204WebApp.Pages
{
    [FeatureGate("ShowSection")]
    public class FeatureFlagModel : PageModel
    {
        public FeatureFlagModel(IFeatureManager featureManager)
        {
            FeatureManager = featureManager;
            var Beta=FeatureManager.IsEnabledAsync("Beta").Result;
            var ShowSection = FeatureManager.IsEnabledAsync("ShowSection").Result;

        }

        public IFeatureManager FeatureManager { get; }

        public void OnGet()
        {
        }
    }
}
