 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using System.Diagnostics;

namespace ConnectiveSport
{
	public class AzureService
	{
		static AzureService _instance;
		static readonly string AzureDomain = "https://nhtsport.azurewebsites.net/";
		static readonly string localDbFilename = "nhtsportstore.db";

		public AzureService()
		{
			var url = new Uri(AzureDomain);
			var store = new MobileServiceSQLiteStore($"{url.Host}.db");
			store.DefineTable<Goal>();

			Client.SyncContext.InitializeAsync(store);

			GoalManager = new GoalManager();

		}

		public GoalManager GoalManager
		{
			get;
			private set;
		}

		public static AzureService Instance
		{
			get
			{
				return _instance ?? (_instance = new AzureService());
			}
		}


		MobileServiceClient _client;

		public MobileServiceClient Client
		{
			get
			{
				if (_client == null)
					_client = new MobileServiceClient(AzureDomain);
				return _client;
			}
		}
		public async Task<bool> SyncAllAsync()
		{
			var list = new List<Task<bool>>();

			list.Add(GoalManager.SyncAsync());

			var successes = await Task.WhenAll(list).ConfigureAwait(false);
			return successes.Any(x => !x);
		}
		
	}
}
