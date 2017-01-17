using System;
using Newtonsoft.Json;
namespace ConnectiveSport
{
	public class Goal : BaseModel
	{
		public string Text { get; set; }

		public bool Complete { get; set; }
	}


}
