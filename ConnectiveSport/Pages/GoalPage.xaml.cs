using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class GoalPage : GoalPageXaml
	{
		public GoalPage()
		{
			InitializeComponent();
			Title = "GOAL";
		}
	}

	public partial class GoalPageXaml : BaseContentPage<GoalPageViewModel>
	{

		public GoalPageXaml() 
		{ 
		}
	}

}
