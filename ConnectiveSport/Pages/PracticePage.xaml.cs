using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading;
namespace ConnectiveSport
{
	

	public partial class PracticePage : PracticePageXaml
	{
		Boolean timerEnabled = false;
		int val = 900;
		public PracticePage()
		{
			Initialize();

		}

		void Initialize()
		{
			//throw new NotImplementedException();
			InitializeComponent();


			TimeSpan result = TimeSpan.FromSeconds(val);
			string fromTimeString = result.ToString("mm':'ss");

			timer.Text = fromTimeString;



			Device.StartTimer(TimeSpan.FromSeconds(1), OnTick);
		}

		bool OnTick()
		{
			
			if (timerEnabled)
			{
				val--;

				TimeSpan result = TimeSpan.FromSeconds(val);
				string fromTimeString = result.ToString("mm':'ss");

				timer.Text = fromTimeString;

				return true;

			}
			else
				return false;

		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (timerEnabled)
			{
				timerEnabled = false;
				timerToggle.Text = "Resume";
			}
			else {
				timerToggle.Text = "Pause";
				timerEnabled = true;
				Device.StartTimer(TimeSpan.FromSeconds(1), OnTick);

			}
		}
	}


	public partial class PracticePageXaml : BaseContentPage<PracticePageViewModel>
	{

	}
}
