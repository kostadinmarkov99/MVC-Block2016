using System.Web;
using System.Web.Mvc;

namespace Bulgaria_at_the_Olympics
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
