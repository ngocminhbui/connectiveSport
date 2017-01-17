using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace ConnectiveSport
{
	public class SqlGoalManager : SqlBaseManager<Goal>
	{
		public Task<List<Goal>> GetGoalsNotDoneAsync()
		{
			return SqlDatabase.Instance.Database.QueryAsync<Goal>("SELECT * FROM [Goal] WHERE [Complete] = 0");
		}
	}
}
