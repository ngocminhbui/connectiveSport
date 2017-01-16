using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class GoalPage : GoalPageXaml
	{
		public GoalPage()
		{
			Initialize();

		}

		void Initialize()
		{
			InitializeComponent();
			Title = "GOAL";
			this.LoadGoals();
		}

		void LoadGoals()
		{
			ViewModel.GetAvailableGoals();
			list.ItemsSource = ViewModel.GoalsList;
		}

		async void Add_Clicked(object sender, System.EventArgs e)
		{
			var page = new AddGoalPage();

			await Navigation.PushAsync(page);
		}
	}

	public partial class GoalPageXaml : BaseContentPage<GoalPageViewModel>
	{

		public GoalPageXaml() 
		{ 
		}
	}

}
