using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public partial class MainTabbedPage : MainTabbedPageXaml
	{
		public MainTabbedPage()
		{
			InitializeComponent();
		}
		public MainTabbedPage(string atid)
		{
			InitializeComponent();

		}
	}
	public partial class MainTabbedPageXaml : BaseContentPage<BaseViewModel>
	{
	}
}
