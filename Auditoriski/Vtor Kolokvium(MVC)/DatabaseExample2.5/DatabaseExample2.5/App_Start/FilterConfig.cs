using System.Web;
using System.Web.Mvc;

namespace DatabaseExample2._5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //za bilo koj kontroler, akcija ke mora da sme najaveni za da imame pristap
        }
    }
}
