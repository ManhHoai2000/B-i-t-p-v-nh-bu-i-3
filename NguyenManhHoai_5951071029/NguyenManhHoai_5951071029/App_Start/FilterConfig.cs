using System.Web;
using System.Web.Mvc;

namespace NguyenManhHoai_5951071029
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
