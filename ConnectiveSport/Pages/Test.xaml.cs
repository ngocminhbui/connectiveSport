using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class Test : TabbedPage
	{
		public Test()
		{
			InitializeComponent();
			//NavigationPage.SetHasNavigationBar(this, false);
			//var navigationPage = new NavigationPage(new ContentPage());
			//navigationPage.Title = "Schedule";


			//Children.Add(new ContentPage());
			//Children.Add(navigationPage);

			Children.Add(new ContentPage());
			Children.Add(new ContentPage());
			Children.Add(new ContentPage());
			Children.Add(new ContentPage());
			Children.Add(new ContentPage());

		}
	}
}
