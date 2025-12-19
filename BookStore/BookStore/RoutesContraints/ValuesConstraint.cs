using System;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace BookStore.RoutesContraints
{
    public class ValuesConstraint : IRouteConstraint
    {
        private readonly string[] validOptions;
        public ValuesConstraint(string options)
        {
            validOptions = options.Split('|');
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            object value;
            if (values.TryGetValue(parameterName, out value) &&  value != null)
            {
                var parameterValue = values[parameterName]?.ToString();
                return validOptions.Contains(parameterValue, StringComparer.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}