using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class FriendPage : FriendPageXaml
	{
		public FriendPage()
		{
			Initialize();

		}

		async void AcceptChallengeClicked(object sender, System.EventArgs e)
		{
			var page = new PracticePage();

			await Navigation.PushAsync(page);
		}
		async void ChallengeClicked(object sender, System.EventArgs e)
		{
			

		}

		public void Initialize()
		{
			InitializeComponent();

			Title = "Friendlist";
			this.LoadFriendList();

		}

		public void LoadFriendList()
		{
			
			ViewModel.GetAvailableFriends();
			list.ItemsSource = ViewModel.FriendsList;
		}

		protected override void OnAppearing()
		{
			
		}

	}

	public partial class FriendPageXaml : BaseContentPage<FriendPageViewModel>
	{

	}
}
