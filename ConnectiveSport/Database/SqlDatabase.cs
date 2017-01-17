using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.Diagnostics;

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
			try
			{
				database.CreateTableAsync<League>().Wait();
				database.CreateTableAsync<Goal>().Wait();
				database.CreateTableAsync<Sport>().Wait();
				database.CreateTableAsync<Athelete>().Wait();
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Unable to create table async\n" + ex);

			}
			GoalManager = new SqlGoalManager();
			SportManager = new SqlSportManager();
			AthleteManager = new SqlAthleteManager();
			LeagueManager = new SqlLeagueManager();

		}

		public SqlGoalManager GoalManager
		{
			get;
			private set;
		}

		public SqlSportManager SportManager
		{
			get;
			private set;
		}

		public SqlAthleteManager AthleteManager
		{
			get;
			private set;
		}

		public SqlLeagueManager LeagueManager
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
