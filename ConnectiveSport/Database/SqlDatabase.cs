using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
namespace ConnectiveSport
{
	public class SqlDatabase
	{
		static SqlDatabase _instance;
		readonly SQLiteAsyncConnection database;
		static readonly string dbPath = "nhtsportstore.db";
		public SqlDatabase()
		{
			database = new SQLiteAsyncConnection(DependencyService.Get<IFileHelper>().GetLocalFilePath(dbPath));
			database.CreateTableAsync<League>().Wait();
			database.CreateTableAsync<Goal>().Wait();

			GoalManager = new SqlGoalManager();
		}

		public SqlGoalManager GoalManager
		{
			get;
			private set;
		}
		public static SqlDatabase Instance
		{
			get
			{
				return _instance ?? (_instance = new SqlDatabase());
			}
		}
		public SQLiteAsyncConnection Database
		{
			get
			{
				return database;
			}
		}

	}
}
