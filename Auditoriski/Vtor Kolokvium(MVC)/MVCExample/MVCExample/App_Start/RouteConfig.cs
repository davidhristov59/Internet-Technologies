using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //TODO - ruta kreiraj
            //string name, string url
            //prv parametar mapiraj vo id, vtor parametar mapiraj vo artist_album {id} i {artist_album}
            routes.MapRoute("detailswith2parameters",
                "store/details/{id}/{artist_album}",
                new { controller = "Store", action = "Details"},
                new { id = @"1|5", artist_album = @"\w*\d{4}" } ///store/details/1/test1234
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
