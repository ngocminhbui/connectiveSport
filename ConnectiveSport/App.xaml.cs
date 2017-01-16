using System;
using Xamarin.Forms;
using Xamarin.Auth;
using Facebook;

namespace ConnectiveSport
{
	public partial class App : Application
	{
		static App _instance;

		public App()
		{
			_instance = this;
			SetDefaultPropertyValues();

			InitializeComponent();
		}

		void SetDefaultPropertyValues()
		{
			//throw new NotImplementedException();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			//MobileCenter.Start(typeof(Analytics), typeof(Crashes));
			//MessagingCenter.Subscribe<object, Exception>(this, Messages.ExceptionOccurred, OnAppExceptionOccurred);

			//Settings.AthleteId = "DF";

			//if (Settings.AthleteId == null || Settings.RegistrationComplete)
			//{
				StartRegistrationFlow();
			//}
			//else
			//	StartAuthenticationFlow();
		}

		void StartAuthenticationFlow()
		{




		}

		void StartRegistrationFlow()
		{
			//throw new NotImplementedException();
			this.MainPage  = new WelcomeStartPage().WithinNavigationPage();
		}


		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
