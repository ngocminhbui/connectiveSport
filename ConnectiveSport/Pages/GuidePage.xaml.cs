using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace ConnectiveSport
{
	public partial class GuidePage : GuidePageXaml
	{
		public GuidePage()
		{
			Initialize();
		}



		protected override void OnAppearing()
		{
			base.OnAppearing();

			list.ItemSelected += OnListItemSelected;

		}

		void Initialize()
		{
			InitializeComponent();
			Title = "Guide";

			LoadLeagues();
		}

		public void LoadLeagues()
		{
			ViewModel.GetAvailableSportGuides();
			list.ItemsSource = ViewModel.SportsVM;
		}


		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (list.SelectedItem == null)
				return;

			var vm = list.SelectedItem as SportViewModel;

			DisplayAlert("DF SElected", vm.Name, "ok");

		}


	}
	public partial class GuidePageXaml : BaseContentPage<GuidePageViewModel>
	{

	}
}
