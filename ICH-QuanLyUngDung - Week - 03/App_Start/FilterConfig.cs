using System.Web;
using System.Web.Mvc;

namespace ICH_QuanLyUngDung___Week___03
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
