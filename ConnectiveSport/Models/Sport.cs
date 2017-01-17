using System;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ConnectiveSport
{
	public class Sport:BaseModel 
	{
		public string Name { get; set; }
		public string ImageURL { get; set; }
		public bool IsAcitivated { get; set; }

	}
}

