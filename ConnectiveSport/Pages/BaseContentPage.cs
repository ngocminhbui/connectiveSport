﻿using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class BaseContentPage<T> : MainBaseContentPage where T : BaseViewModel, new()
	{
		protected T _viewModel;

		public T ViewModel
		{
			get
			{
				return _viewModel ?? (_viewModel = new T());
			}
		}

		~BaseContentPage()
		{
			_viewModel = null;
		}

		public BaseContentPage()
		{
			BindingContext = ViewModel;
		}
	}
	public class MainBaseContentPage : ContentPage
	{
		public Color BarBackgroundColor { get;  set; }

		public Color BarTextColor { get;  set; }


		
		public MainBaseContentPage()
		{
			BarBackgroundColor = (Color)Application.Current.Resources["grayPrimary"];
			BarTextColor = Color.White;
			BackgroundColor = Color.White;
		}

		public NavigationPage WithinNavigationPage()
		{
			//throw new NotImplementedException();
			var nav = new NavigationPage(this);
			ApplyTheme(nav);
			return nav;
		}

		public void ApplyTheme(NavigationPage nav)
		{
			nav.BarBackgroundColor = BarBackgroundColor;
			nav.BarTextColor = BarTextColor;
		}
	}
}

