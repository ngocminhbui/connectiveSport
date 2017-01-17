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

			//dummy friends
			FriendsList = new ObservableCollection<AthleteProfileViewModel>();
			//FriendsList.Add(new AthleteProfileViewModel(new Athelete { Name = "An Luong", Alias = "An cute :v" ,ImageURL = "http://findicons.com/files/icons/1072/face_avatars/300/a04.png" }));
			//FriendsList.Add(new AthleteProfileViewModel(new Athelete { Name = "Le Do", Alias = "Le cute :v", ImageURL = "http://findicons.com/files/icons/1072/face_avatars/300/a04.png" }));
			//FriendsList.Add(new AthleteProfileViewModel(new Athelete { Name = "Minh Bui", Alias = "Minh :v", ImageURL = "http://findicons.com/files/icons/1072/face_avatars/300/a04.png" }));

			//SqlDatabase.Instance.Database.CreateTableAsync<Athelete>().Wait();
		

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
				SqlDatabase.Instance.AthleteManager.SaveItemAsync(new Athelete { Name = Name, Alias = Name + " cute", ImageURL = Url });
            }
        }

	}
}

