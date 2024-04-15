

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace WebMonitoring.Models
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
             request.QueryString.HasValue
                 ? $"{request.Path}{request.QueryString}"
                 : request.Path.ToString();

        public static string Controller(this HttpRequest request)
        {
            var routeValues = request.HttpContext.Request.RouteValues;

            if (routeValues.ContainsKey("controller"))
                return (string)routeValues["controller"];

            return string.Empty;
        }

        public static string Action(this HttpRequest request)
        {
            var routeValues = request.HttpContext.Request.RouteValues;

            if (routeValues.ContainsKey("action"))
                return (string)routeValues["action"];

            return string.Empty;
        }
    }
}
