using System.Web.Mvc;

namespace WebTechPlayGround.Areas.ASPNET_MVC_PartialView
{
    public class ASPNET_MVC_PartialViewAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ASPNET_MVC_PartialView";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ASPNET_MVC_PartialView_default",
                "ASPNET_MVC_PartialView/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}