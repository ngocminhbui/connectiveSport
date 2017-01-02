using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class MainTabPage : MainTabPageXaml
	{
		public MainTabPage()
		{
			Initialize();


		}

		void Initialize()
		{
			InitializeComponent();
			Children.Add(new LeaguesPage());
			Children.Add(new LeaguesPage());
			Children.Add(new LeaguesPage());

		}
	}

	public partial class MainTabPageXaml : TabbedPage
	{

	}

}