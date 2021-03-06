﻿namespace forCrowd.WealthEconomy.WebApi
{
    using BusinessObjects;
    using HttpClientHandlers;
    using Microsoft.AspNet.Identity;
    using Microsoft.Owin;
    using Microsoft.Owin.Security.Facebook;
    using Microsoft.Owin.Security.Google;
    using Microsoft.Owin.Security.MicrosoftAccount;
    using Microsoft.Owin.Security.OAuth;
    using Owin;
    using Providers;
    using System;

    public class AuthConfig
    {
        public static string PublicClientId { get; private set; }

        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public static void ConfigureAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            // TODO Is this correct to make DbContext accessible from Web application?
            app.CreatePerOwinContext(WealthEconomyContext.Create);
            app.CreatePerOwinContext<UserManagerFactory>(UserManagerFactory.Create);

            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // Configure the application for OAuth based flow
            PublicClientId = "self";
            var OAuthServerOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/api/Token"),
                Provider = new ApplicationOAuthProvider(PublicClientId),
                //AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"), // TODO ?
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
                AllowInsecureHttp = true
            };

            // Enable the application to use bearer tokens to authenticate users
            app.UseOAuthBearerTokens(OAuthServerOptions);

            // Configure Facebook login
            var facebookAppId = Framework.AppSettings.FacebookAppId;
            var facebookAppSecret = Framework.AppSettings.FacebookAppSecret;

            if (!string.IsNullOrWhiteSpace(facebookAppId) && !string.IsNullOrWhiteSpace(facebookAppSecret))
            {
                var facebookAuthOptions = new FacebookAuthenticationOptions()
                {
                    AppId = Framework.AppSettings.FacebookAppId,
                    AppSecret = Framework.AppSettings.FacebookAppSecret,
                    UserInformationEndpoint = "https://graph.facebook.com/v2.5/me?fields=email",
                    BackchannelHttpHandler = new FacebookBackChannelHandler(),
                    CallbackPath = new PathString("/api/Account/ExternalLoginFacebook") // Middleware is going to handle this, no need to implement
                };
                facebookAuthOptions.Scope.Add("email");
                app.UseFacebookAuthentication(facebookAuthOptions);
            }

            // Configure Google login
            var googleClientId = Framework.AppSettings.GoogleClientId;
            var googleClientSecret = Framework.AppSettings.GoogleClientSecret;

            if (!string.IsNullOrWhiteSpace(googleClientId) && !string.IsNullOrWhiteSpace(googleClientSecret))
            {
                var googleAuthOptions = new GoogleOAuth2AuthenticationOptions()
                {
                    ClientId = googleClientId,
                    ClientSecret = googleClientSecret,
                    CallbackPath = new PathString("/api/Account/ExternalLoginGoogle") // Middleware is going to handle this, no need to implement
                };
                app.UseGoogleAuthentication(googleAuthOptions);
            }

            // Configure Microsoft Accounts login
            var microsoftClientId = Framework.AppSettings.MicrosoftClientId;
            var microsoftClientSecret = Framework.AppSettings.MicrosoftClientSecret;

            if (!string.IsNullOrWhiteSpace(microsoftClientId) && !string.IsNullOrWhiteSpace(microsoftClientSecret))
            {
                var microsoftAccountAuthOptions = new MicrosoftAccountAuthenticationOptions()
                {
                    ClientId = Framework.AppSettings.MicrosoftClientId,
                    ClientSecret = Framework.AppSettings.MicrosoftClientSecret,
                    CallbackPath = new PathString("/api/Account/ExternalLoginMicrosoft") // Middleware is going to handle this, no need to implement
                };
                microsoftAccountAuthOptions.Scope.Add("wl.emails");
                app.UseMicrosoftAccountAuthentication(microsoftAccountAuthOptions);
            }
        }
    }
}
