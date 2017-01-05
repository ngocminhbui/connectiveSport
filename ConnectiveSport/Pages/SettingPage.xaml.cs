using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class SettingPage : SettingPageXaml
	{
		public SettingPage()
		{
			InitializeComponent();
			Title = "Setting";

		}

		void OnSharingToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			DisplayAlert("df", "DF", "DF");
		}

		void OnEnableNotiToggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			DisplayAlert("df", "DF", "DF");

		}
	}

	public partial class SettingPageXaml : BaseContentPage<SettingPageViewModel>
	{
		
	}
}
