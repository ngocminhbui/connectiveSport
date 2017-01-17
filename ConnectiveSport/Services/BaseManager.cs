
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices;
using System.Linq;
using System.Text;
namespace ConnectiveSport
{
	public class BaseManager<T> where T : BaseModel
	{
		public virtual string Identifier => "Items";
		IMobileServiceSyncTable<T> table;
		public IMobileServiceSyncTable<T> Table
		{
			get
			{
				return table ?? (table = AzureService.Instance.Client.GetSyncTable<T>());
			}
		}
		public void DropTable()
		{
			table = null;
		}

		public virtual async Task<IList<T>> GetItemsAsync(bool forceRefresh = false)
		{
			if (forceRefresh)
				await PullLatestAsync().ConfigureAwait(false);

			var enu = await Table.ToEnumerableAsync().ConfigureAwait(false);
			return enu.ToList();
		}

		public virtual async Task<T> GetItemAsync(string id, bool forceRefresh = false)
		{
			if (forceRefresh)
				await PullLatestAsync().ConfigureAwait(false);

			var item = await Table.LookupAsync(id).ConfigureAwait(false);
			return item;
		}

		public virtual async Task<bool> UpsertAsync(T item)
		{
			if (item.Idd == null)
			{
				return await InsertAsync(item);
			}
			else
			{
				return await UpdateAsync(item);
			}
		}

		public virtual async Task<bool> InsertAsync(T item)
		{
			var pull = await PullLatestAsync().ConfigureAwait(false);
			await Table.InsertAsync(item).ConfigureAwait(false);
			var push = await SyncAsync().ConfigureAwait(false);

			if (push)
			{
				var updated = await GetItemAsync(item.Idd, false).ConfigureAwait(false);

			}

			return pull && push;
		}

		public virtual async Task<bool> UpdateAsync(T item)
		{
			//#if DEBUG
			//var lookup = await GetItemAsync(item.Id, true);
			//Debug.WriteLine($"Before Lookup: {lookup.Version} - {lookup.UpdatedAt}");
			//#endif

			var pull = await PullLatestAsync().ConfigureAwait(false);
			await Table.UpdateAsync(item).ConfigureAwait(false);
			var push = await SyncAsync().ConfigureAwait(false);
			var updated = await GetItemAsync(item.Idd, false).ConfigureAwait(false);


			//Debug.WriteLine($"After Update: {item.Version} - {item.UpdatedAt}");
			return pull && push;
		}

		public virtual async Task<bool> RemoveAsync(T item)
		{
			var pull = await PullLatestAsync().ConfigureAwait(false);
			await Table.DeleteAsync(item).ConfigureAwait(false);
			var push = await SyncAsync().ConfigureAwait(false);
			return pull && push;
		}

		public async Task<bool> PullLatestAsync()
		{
			try
			{
				//Debug.WriteLine($"Pulling for table {Identifier}");
				await Table.PullAsync($"all{Identifier}", Table.CreateQuery()).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Pull sync error for {Identifier}\n" + ex);
				//MessagingCenter.Send(new object(), Messages.ExceptionOccurred, ex);
				return false;
			}
			return true;
		}


		public async Task<bool> SyncAsync()
		{
			try
			{
				await AzureService.Instance.Client.SyncContext.PushAsync();

				if (!(await PullLatestAsync()))
					return false;
			}
			catch (MobileServicePushFailedException ex)
			{
				Debug.WriteLine("Unable to sync\n" + ex);
				return false;
			}

			return true;
		}
	}
}
