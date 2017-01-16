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

		//void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		//{
		//	ViewModel.SportsVM.RemoveAt(0);

		//}


		protected override void OnAppearing()
		{
			base.OnAppearing();

			Indoorlist.ItemSelected += OnListItemSelected;

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
			Indoorlist.ItemsSource = ViewModel.SportsVM;
			//Arealist.ItemsSource = ViewModel.SportsVM;
			//Followerlist.ItemsSource = ViewModel.SportsVM;
		}


		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (Indoorlist.SelectedItem == null)
				return;

			var vm = Indoorlist.SelectedItem as SportViewModel;

			DisplayAlert("DF SElected", vm.Name, "ok");

		}


	}
	public partial class GuidePageXaml : BaseContentPage<GuidePageViewModel>
	{

	}
}
