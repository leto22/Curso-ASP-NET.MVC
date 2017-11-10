using System.Web;
using System.Web.Mvc;

namespace Curso.ASPNETMVC.TreinaWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
