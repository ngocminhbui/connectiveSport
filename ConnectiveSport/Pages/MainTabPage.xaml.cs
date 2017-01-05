using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class MainTabPage : MainTabPageXaml
	{
		public MainTabPage()
		{
			Initialize();


		}

		void Initialize()
		{
			Title = "Sport Centre";
			InitializeComponent();
			Children.Add(new GuidePage());
			Children.Add(new FriendPage());
			Children.Add(new GoalPage());

		}

		const string _setting = "Setting";
		const string _refresh = "Refresh";
		const string _logout = "Log Out";
		const string _about = "About";


		async void OnMoreClicked(object sender, EventArgs e)
		{
			var lst = GetMoreMenuOptions();
			var action = await DisplayActionSheet("Additional actions", "Cancel", null, lst.ToArray());

			switch (action)
			{
				case _setting:
					OnSettingSelected();
					break;
				case _refresh:
					OnRefreshSelected();
					break;
				case _logout:
					OnLogOutSelected();
					break;
				case _about:
					OnAboutSelected();
					break;
				default:
					break;
			};

		}

		async void OnAboutSelected()
		{
			DisplayAlert("DF", "DFFD", "DFFD");
		}

		async void OnLogOutSelected()
		{
			throw new NotImplementedException();
		}

		async void OnSettingSelected()
		{
			var page = new SettingPage();
			page.AddDoneButton();

			await Navigation.PushModalAsync(page.WithinNavigationPage());
		}

		void OnRefreshSelected()
		{
			throw new NotImplementedException();
		}

		List<String> GetMoreMenuOptions()
		{
			List<String> str = new List<String>();
			str.Add(_setting);
			str.Add(_refresh);
			str.Add(_about);
			str.Add(_logout);
			return str;
				
		}
}

	public partial class MainTabPageXaml : TabbedPage
	{

	}

}