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

		void AcceptChallengeClicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
		void ChallengeClicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();

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
