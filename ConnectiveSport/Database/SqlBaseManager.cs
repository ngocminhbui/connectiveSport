using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace ConnectiveSport
{
	public class SqlBaseManager<T> where T : BaseModel, new()
	{
		
		public Task<List<T>> GetItemsAsync()
		{
			return SqlDatabase.Instance.Database.Table<T>().ToListAsync(); 	
		}

		public Task<T> GetItemAsync(int id)
		{
			return SqlDatabase.Instance.Database.Table<T>().Where(i => i.ID == id).FirstOrDefaultAsync();
		}

		public Task<int> SaveItemAsync(T item)
		{
			if (item.ID != 0)
			{
				return SqlDatabase.Instance.Database.UpdateAsync(item);
			}
			else {
				return SqlDatabase.Instance.Database.InsertAsync(item);
			}
		}

		public Task<int> InsertItemAsync(T item)
		{
			
			return SqlDatabase.Instance.Database.InsertAsync(item);

		}

		public Task<int> UpdateItemAsync(T item)
		{

			return SqlDatabase.Instance.Database.UpdateAsync(item);

		}

		public Task<int> DeleteItemAsync(T item)
		{
			return SqlDatabase.Instance.Database.DeleteAsync(item);
		}
	}
}
