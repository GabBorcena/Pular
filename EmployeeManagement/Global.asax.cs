using EmployeeManagement.Repositories;
using System; 
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EmployeeManagement
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start()
        {
            if (Session["USER_SESSION"] == null)
            {
                UserSettingsRepository userSettings = new UserSettingsRepository();
                string userId = Request.LogonUserIdentity.Name.ToString(); 

                if (userId != null)
                {
                    Session["USER_SESSION"] = userId;
                }
                else
                {
                    Session["USER_SESSION"] = null;
                }
            }
        }

        protected void Session_End()
        {
            Session["USER_SESSION"] = null;
        }
        protected void Logout()
        {
            Session["USER_SESSION"] = null;
        }
        protected void Application_Error()
        {
            Exception err = Server.GetLastError().GetBaseException();
            string url = Request.Url.ToString();
            string message = err.Message;

            Session["ErrorURl"] = url;
            Session["ErrorMessage"] = message;

            //Please log this to database ..
        }
    } 
}
