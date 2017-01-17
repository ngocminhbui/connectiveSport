using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System;
using System.Diagnostics;

namespace ConnectiveSport
{
	public class GuidePageViewModel : BaseViewModel
	{
		public ObservableCollection<SportViewModel> SportsVM
		{
			get;
			set;
		}



		public GuidePageViewModel()
		{

		}

		public void GetAvailableSportGuides(bool forceRefresh = false)
		{
			//dummy sport
			SportsVM = new ObservableCollection<SportViewModel>();
			SportsVM.Add(new SportViewModel(new Sport { Name = "Swimming", ImageURL = "http://www.top10base.com/wp-content/uploads/2014/08/play-sports.png" }));
			SportsVM.Add(new SportViewModel(new Sport { Name = "Punching", ImageURL = "http://www.top10base.com/wp-content/uploads/2014/08/play-sports.png" }));
			SportsVM.Add(new SportViewModel(new Sport { Name = "Hitting", ImageURL = "http://goqii.com/blog/wp-content/uploads/all-sports.png" }));
			Goal g = new Goal();

		}		 


	}
}

