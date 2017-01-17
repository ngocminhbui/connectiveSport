using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Diagnostics;
using Facebook;

namespace ConnectiveSport
{
	public class FriendPageViewModel : BaseViewModel
	{
		public FriendPageViewModel()
		{
			
		}

		public ObservableCollection<AthleteProfileViewModel> FriendsList { get; set; }

		public void GetAvailableFriends(bool forceRefresh = false)
		{
            FacebookClient fb = new FacebookClient(Settings.AccessToken);
            string Name = "";
            string Url = "";

            dynamic FriendlistData = fb.Get("me/friends?fields=picture,name");
            foreach (var friend in FriendlistData["data"])
            {
                Name = friend["name"];
                dynamic picture = friend["picture"];
                Url = picture["data"]["url"];
                FriendsList.Add(new AthleteProfileViewModel(new Athelete { Name = Name, Alias = Name + " cute", ImageURL = Url }));
            }
        }
	}
}

