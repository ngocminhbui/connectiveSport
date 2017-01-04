using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{

	public partial class League{
	public string Name { get; set; }

		public string ImageURL { get; set; }

		public League()
		{

			ImageURL = "https://www.google.com.vn/images/branding/googlelogo/1x/googlelogo_color_272x92dp.png";
		}
	}


	public partial class LeaguesPage : LeaguesPageXaml
	{
		public LeaguesPage()
		{
			



			Initialize();



		}

		void Initialize()
		{
			InitializeComponent();
			Title = "Leagues";
			List<League> Leagues = new List<League>();
			Leagues.Add(new League{  Name = "Swimming"});
			Leagues.Add(new League{ Name = "Punching"});
			Leagues.Add(new League{  Name = "Hitting"});

				

			list.ItemsSource = Leagues;

		}

	}

	public partial class LeaguesPageXaml : BaseContentPage<BaseViewModel>
	{
		
	}
}
