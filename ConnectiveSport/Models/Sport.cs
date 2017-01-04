using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class Sport:BaseViewModel 
	{
		public string Name { get; set; }

		public string ImageURL { get; set; }

		public bool IsAcitivated { get; set; }

		public Sport()
		{
			
		}
	}
}

