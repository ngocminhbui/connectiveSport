using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class AddGoalPageViewModel : BaseViewModel
	{
		public AddGoalPageViewModel()
		{
			
		}

		internal void AddNewGoal(GoalViewModel s)
		{
			String sport = s.Sport;
			String type = s.Type;
			String content = s.Content;
			bool IsCompleted = !s.IsInCompleted;

			//
		}
	}
}

