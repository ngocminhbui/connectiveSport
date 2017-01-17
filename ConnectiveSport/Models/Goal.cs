using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class Goal : ContentPage
	{
		public Sport Sport { get; set; } 

		public string GoalType { get; set; } // string -> GoalType sau nay GoalType co cac loai nhu ngay/ thang / nam

		public string Content { get; set; } 

		public bool IsCompleted { get; set; }

		public Goal()
		{
			
		}
	}
}


