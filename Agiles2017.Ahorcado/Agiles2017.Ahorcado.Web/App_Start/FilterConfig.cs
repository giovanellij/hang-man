using System.Web;
using System.Web.Mvc;

namespace Agiles2017.Ahorcado.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
