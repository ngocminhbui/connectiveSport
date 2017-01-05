using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class AthleteProfileViewModel : BaseViewModel
	{
		public Athelete athlete;


		public String Alias { get; set;}
		public String Name { get; set;}
		public String ImageURL { get; set;}

		public AthleteProfileViewModel()
		{
			
		}

		public AthleteProfileViewModel(Athelete a)
		{
			this.Alias = a.Alias;
			this.Name = a.Name;
			this.ImageURL = a.ImageURL;
		}
	}

}

