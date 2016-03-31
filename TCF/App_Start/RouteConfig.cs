using System.Web.Mvc;
using System.Web.Routing;
using TCF.Controllers;

namespace TCF
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var dynamicController = "Posts";
            routes.MapRoute("TagForRealThisTime", "tag/{idAndSlug}", new { controller = dynamicController, action = "Tag" }, namespaces);
            routes.MapRoute("Tag", "tag/{id}-{slug}", new { controller = "Posts", action = "Tag" }, namespaces);

            routes.MapRoute("PostForRealThisTime", "post/{idAndSlug}", new { Controller = "Posts", action = "Show" }, namespaces);
            routes.MapRoute("Post", "post/{id}-{slug}", new { Controller = "Posts", action = "Show" }, namespaces);

            routes.MapRoute("Login", "Login", new { controller = "Auth", action = "Login" }, namespaces);

            routes.MapRoute("Logout", "Logout", new { controller = "Auth", action = "Logout" }, namespaces);

            routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" }, namespaces);

            routes.MapRoute("Sidebar", "", new { Controller = "Layout", Action = "Sidebar" }, namespaces);
        }
    }
}
