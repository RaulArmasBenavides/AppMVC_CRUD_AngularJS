using System.Web;
using System.Web.Mvc;

namespace AppMVC_CRUD_AngularJS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
