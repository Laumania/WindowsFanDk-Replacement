using System.Web;
using System.Web.Mvc;

namespace WindowsFanDK_Replacement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
