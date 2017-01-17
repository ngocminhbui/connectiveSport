using System;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ConnectiveSport
{
	public class Sport:BaseModel 
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("imageurl")]
		public string ImageURL { get; set; }
		[JsonProperty("isactivated")]
		public bool IsAcitivated { get; set; }

		public Sport()
		{
			
		}
	}
}

