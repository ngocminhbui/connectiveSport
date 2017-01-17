using System;
namespace ConnectiveSport
{
	public class GoalViewModel:BaseViewModel
	{


		public Goal goal;


		public String Sport { get; set; }
		public String Type { get; set; }
		public String Content { get; set; }
		public bool IsInCompleted { get; set; }


		public GoalViewModel()
		{

		}

		public GoalViewModel(Goal a)
		{
			//this.Sport = a.Sport.Name;
			this.Type = a.GoalType;
			this.Content = a.Content;
			this.IsInCompleted = !a.IsCompleted;
		}



	}
}