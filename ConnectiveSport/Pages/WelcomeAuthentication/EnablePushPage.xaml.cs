using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class EnablePushPage : EnablePushPageXaml
	{
		public EnablePushPage()
		{
			Initialize();
		}

		void Initialize()
		{
			NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent();

			Title = "Enable Push";
			//profileStack.Opacity = 0;

			btnCont.Clicked += async (sender, e) =>
			{
				await AnimateToMainPage();
			};
		}

		async Task AnimateToMainPage()
		{
			// Hieu ung chuyen trang//
			await MoveToMainPage();
		}

		async Task MoveToMainPage()
		{
			//Settings.RegistrationComplete = true;
			var page = new Test();
			////await page.LoadLeagues();

			//await Task.Delay(200);
			await Navigation.PushAsync(page);

			while (Navigation.NavigationStack.Count > 0)
				Navigation.RemovePage(Navigation.NavigationStack[0]); 
		}
	}


	public partial class EnablePushPageXaml :BaseContentPage<AthleteProfileViewModel>
	{
	}
}
