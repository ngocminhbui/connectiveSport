using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Auth;

using ConnectiveSport;
using ConnectiveSport.Droid;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Facebook;

[assembly: ExportRenderer(typeof(LoginFacebookPage), typeof(LoginPageRenderer))]
namespace ConnectiveSport.Droid
{
    class LoginPageRenderer: PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            var activity = this.Context as Activity;
            var auth = new OAuth2Authenticator(
                clientId: "360638960973220",
                scope: "user_friends,public_profile,email",
                authorizeUrl: new Uri("https://m.facebook.com/dialog/oauth/"),
                redirectUrl: new Uri("http://localhost:3000/"));

            auth.Completed += (sender, eventArgs) =>
            {
                Settings.AccessToken = eventArgs.Account.Properties["access_token"];
                FacebookClient fb = new FacebookClient(Settings.AccessToken);
                var profile = fb.Get("me/?fields=picture,name");
                //Settings.UserProfile.Name = profile["name"];
                //Settings.UserProfile.ImageURL = profile["picture"]["data"]["url"];
                //DAO.SaveUserInfo(Settings.UserProfile);
            };
            activity.StartActivity(auth.GetUI(activity));
        }
    }
}