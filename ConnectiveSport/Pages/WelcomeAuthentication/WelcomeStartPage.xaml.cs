using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ConnectiveSport;

namespace ConnectiveSport
{
	public partial class WelcomeStartPage : WelcomeStartPageXaml
	{
		public WelcomeStartPage()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			Initialize();
		}

		void Initialize()
		{
			InitializeComponent();
			Title = "Welcome!";

			btnAuthenticate.Clicked += async (sender, e) =>
			{
                //await ViewModel.Authenticate();

                //this.DisplayAlert("dsjf", "dfkj", "Cancel");
                await Navigation.PushAsync(new LoginFacebookPage());
				await Navigation.PushAsync(new SetAliasPage());


			};
		}


	

	}
	public partial class WelcomeStartPageXaml : BaseContentPage<AuthenticationViewModel>
	{
		public WelcomeStartPageXaml() : base()
		{
			
		}

	}
}
