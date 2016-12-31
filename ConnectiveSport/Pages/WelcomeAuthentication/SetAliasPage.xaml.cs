using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class SetAliasPage : SetAliasPageXaml
	{
		public SetAliasPage()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			//ViewModel.AthleteId = App.Instance.CurrentAthlete.Id;

			Initialize();
		}

		void Initialize()
		{
			//throw new NotImplementedException();
			InitializeComponent();
			Title = "Athlete Alias";
			//profileStack.Opacity = 0;

			IsBusy = false;


			btnSave.Clicked += async (sender, e) =>
			{
				
				var page = new EnablePushPage();
				//page.ViewModel.AthleteId = ViewModel.AthleteId;

				await Navigation.PushAsync(page);

			};
		}
	}
	public partial class SetAliasPageXaml : BaseContentPage<AthleteProfileViewModel>
	{
		
	}

}
