﻿using System.Web.Mvc;
using System.Web.Routing;

namespace ThreatModelingGame.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "New Game",
                url: "Game/New",
                defaults: new { controller = "Game", action = "New" }
            );

            routes.MapRoute(
                name: "Game",
                url: "Game/{gameId}",
                defaults: new { controller = "Game", action = "Show" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
