using System;

using Xamarin.Forms;
using SQLite;
namespace ConnectiveSport
{
	public class League: BaseModel
	{
		
		public string Name { get; set; }

		public string ImageURL { get;  set; }

		public bool IsAcitivated { get;  set; }


	}
}

