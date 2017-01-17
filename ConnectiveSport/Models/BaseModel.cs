using System;
using SQLite;
namespace ConnectiveSport
{
	public class BaseModel
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		public string Idd { get; set; } // Id for AzureService


	}
}
