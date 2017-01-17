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
			LoadContent();
			LoadItemsForSportPicker();
			LoadItemsForTypePicker();
		}

		void LoadContent()
		{
			ViewModel.LoadLists();
		}

		void LoadItemsForTypePicker()
		{
			foreach (string s in ViewModel.TypesList)
			{
				Type.Items.Add(s);
			}

		}

		void LoadItemsForSportPicker()
		{
			foreach (string s in ViewModel.SportsList)
			{
				SportPicker.Items.Add(s);
			}	
		}

		void Save_Clicked(object sender, System.EventArgs e)
		{
			GoalViewModel s = new GoalViewModel { Sport = SportPicker.Items[SportPicker.SelectedIndex], Type = Type.Items[Type.SelectedIndex], Content = GoalContent.Text, IsInCompleted = true };
			ViewModel.AddNewGoal(s);
		}
	}
	public partial class AddGoalPageXaml : BaseContentPage<AddGoalPageViewModel>
	{

	}
}
