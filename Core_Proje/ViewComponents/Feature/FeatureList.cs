using BusinessLayer.Conctrete;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;


namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetlist();
            return View(values);
        }
    }
}
