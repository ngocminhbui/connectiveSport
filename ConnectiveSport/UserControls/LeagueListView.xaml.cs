using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class LeagueListView : ListView
	{
		public LeagueListView()
		{
			InitializeComponent();




		}

		async void Practice_Clicked(object sender, System.EventArgs e)
		{
			var page = new PracticePage();

			await Navigation.PushAsync(page);
		}
		void Join_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}


	}
}
