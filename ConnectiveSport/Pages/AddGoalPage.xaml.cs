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
			InitSportPicker();
			Label s = new Label();
			s.Text = "DFFDFDFFDFDFDF";

			SportPicker.Items.Add("DFJDFJDFJDF");
			SportPicker.SelectedIndex = 2;

		}

		async void InitSportPicker()
		{
			var sportList = await SqlDatabase.Instance.SportManager.GetItemsAsync();
			foreach (Sport s in sportList)
			{
				SportPicker.Items.Add(s.Name);
			}
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();


		}
	}
	public partial class AddGoalPageXaml : BaseContentPage<AddGoalPageViewModel>
	{
		
	}
}
