using System;

using System.Collections.ObjectModel;
using Xamarin.Forms;


namespace ConnectiveSport
{
	public class GoalPageViewModel : BaseViewModel
	{
		public GoalPageViewModel()
		{
			
		
		}

		public ObservableCollection<GoalViewModel> GoalsList { get; set; }


		internal void GetAvailableGoals(bool forceRefresh = false)
		{
			//dummy goals

			GoalsList = new ObservableCollection<GoalViewModel>();



			//Sport s = new Sport { Name = "Swimming", ImageURL = "http://www.top10base.com/wp-content/uploads/2014/08/play-sports.png" };

			//GoalsList.Add(new GoalViewModel(new Goal {Sport=s, GoalType="Day", Content="This is a goal", IsCompleted=false }));
			//GoalsList.Add(new GoalViewModel(new Goal { Sport = s, GoalType = "Day", Content = "This is another goal", IsCompleted = true }));
			//GoalsList.Add(new GoalViewModel(new Goal { Sport = s, GoalType = "Day", Content = "This is another goal", IsCompleted = false }));

		}
	}
}

