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
			Title = "LEAGUE";	
		}



	}

	public partial class LeaguesPageXaml : BaseContentPage<BaseViewModel>
	{
		
	}
}
