using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{

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
			Leagues.Add(new League{  Name = "Swimming" , ImageURL="http://www.lboro.ac.uk/media/wwwlboroacuk/external/content/research/sti/slide1-image-tablet.png"});
			Leagues.Add(new League{ Name = "Punching",ImageURL="http://www.top10base.com/wp-content/uploads/2014/08/play-sports.png"});
			Leagues.Add(new League{  Name = "Hitting", ImageURL="http://goqii.com/blog/wp-content/uploads/all-sports.png"});

				

			list.ItemsSource = Leagues;

		}

	}

	public partial class LeaguesPageXaml : BaseContentPage<BaseViewModel>
	{
		
	}
}
