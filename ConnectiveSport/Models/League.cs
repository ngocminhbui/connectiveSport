using System;

using Xamarin.Forms;
using SQLite;
namespace ConnectiveSport
{
	public class League
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		public string Name { get; set; }

		public string ImageURL { get;  set; }

		public bool IsAcitivated { get;  set; }


	}
}

