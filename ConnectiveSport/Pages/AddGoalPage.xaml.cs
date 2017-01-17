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



	}
	public partial class AddGoalPageXaml : BaseContentPage<AddGoalPageViewModel>
	{

	}
}
