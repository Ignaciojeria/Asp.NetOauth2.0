using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using OauthP.Provider;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OauthP
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                //Ruta para solicitar el token. se mandan las credenciales por post.
                TokenEndpointPath = new PathString("/token"),
                Provider = new OAuthAppProvider(),
                //Tiempo de expiración del token
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(2),
                AllowInsecureHttp = true
            };
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}
