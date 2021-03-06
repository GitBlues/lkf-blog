

using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

using WoBlog.Utility;
using WoBlog.Utility.Extensions;


namespace WoBlog.Web.Mvc.Routing
{
    /// <summary>
    /// 路由辅助操作类
    /// </summary>
    public static class RouteHelper
    {
        /// <summary>
        /// 添加命名空间到指定名称的路由配置中
        /// </summary>
        public static void AddRouteNamespaces(string routeName, params string[] namespaces)
        {
            routeName.CheckNotNull("routeName");
            namespaces.CheckNotNull("namespaces");

            if (namespaces.Length == 0)
            {
                return;
            }

            const string namespacesKey = "Namespaces";
            RouteBase routeBase = RouteTable.Routes[routeName];
            if (routeBase == null || !(routeBase is Route))
            {
                return;
            }
            Route route = routeBase as Route;
            if (!route.DataTokens.ContainsKey(namespacesKey))
            {
                route.DataTokens.Add(namespacesKey, namespaces);
            }
            else
            {
                List<string> existsNamespaces = ((string[])route.DataTokens[namespacesKey]).ToList();
                foreach (string @namespace in namespaces)
                {
                    if (existsNamespaces.All(m => m != @namespace))
                    {
                        existsNamespaces.Add(@namespace);
                    }
                }
                route.DataTokens[namespacesKey] = existsNamespaces.ToArray();
            }
        }
    }
}