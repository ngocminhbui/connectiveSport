using System;
using SQLite;
namespace ConnectiveSport
{
	public class BaseModel
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }

		public string Id { get; set; }


	}
}
