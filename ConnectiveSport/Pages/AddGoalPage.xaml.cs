using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class AddGoalPage : AddGoalPageXaml
	{
		public AddGoalPage()
		{
			InitializeComponent();
			//Label s = new Label();
			//s.Text = "DFFDFDFFDFDFDF";
			SportPicker.Items.Add("DFJDFJDFJDF");
			SportPicker.SelectedIndex = 2;
		}



		void Save_Clicked(object sender, System.EventArgs e)
		{
			GoalViewModel s = new GoalViewModel { Sport = SportPicker.Items[SportPicker.SelectedIndex], Type = Type.Items[Type.SelectedIndex], Content = Content., IsInCompleted = true };
			ViewModel.AddNewGoal(s);
		}
	}
	public partial class AddGoalPageXaml : BaseContentPage<AddGoalPageViewModel>
	{

	}
}
