using System;

using Xamarin.Forms;
using SQLite;
namespace ConnectiveSport
{
	public class Goal : BaseModel
	{
		public int SportID { get; set; } 

		public string GoalType { get; set; } // string -> GoalType sau nay GoalType co cac loai nhu ngay/ thang / nam

		public string Content { get; set; } 

		public bool IsCompleted { get; set; }


	}
}


