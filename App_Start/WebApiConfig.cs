using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace OauthP
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

          
            //Formateamos la respuesta que retorna el controllador de xml a Json.

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
