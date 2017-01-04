using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class BaseViewModel 
	{
		public bool IsBusy { get; internal set; }

		public BaseViewModel()
		{
			
		}
	}

	public class Busy : IDisposable
	{
		readonly object _sync = new object();
		readonly BaseViewModel _viewModel;


		public bool IsBusy { get; internal set; }
		public Busy(BaseViewModel viewModel)
		{
			_viewModel = viewModel;
			lock (_sync)
			{
				_viewModel.IsBusy = true;

			}
		}

		public void Dispose()
		{
			lock (_sync)
			{
				_viewModel.IsBusy = false;
			}
		}
	}
}

