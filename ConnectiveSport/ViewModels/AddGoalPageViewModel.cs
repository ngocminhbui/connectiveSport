using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ConnectiveSport
{
	public class AddGoalPageViewModel : BaseViewModel
	{
		public AddGoalPageViewModel()
		{
			
		}

		public List<string> SportsList { get;  set; }
		public List<string> TypesList { get;  set; }

		internal void AddNewGoal(GoalViewModel s)
		{
			String sport = s.Sport;
			String type = s.Type;
			String content = s.Content;
			bool IsCompleted = !s.IsInCompleted;

			//
		}

		internal void LoadLists()
		{
			SportsList.Add("DF");
			TypesList.Add("DSFDSFDSFF");

		}
	}
}

