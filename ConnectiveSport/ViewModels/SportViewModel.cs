using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class SportViewModel : BaseViewModel
	{
		public virtual Sport sport
		{
			get;
			set;
		}

		public string Name { get; set; }

		public string ImageURL { get; set; }



		public SportViewModel()
		{
				
		}
		public SportViewModel(Sport s)
		{
			sport = s;
			this.Name = s.Name;
			this.ImageURL = s.ImageURL;

			//rank,...
				
		}

	}
}

