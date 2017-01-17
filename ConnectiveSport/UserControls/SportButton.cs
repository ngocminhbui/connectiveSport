using System;

using Xamarin.Forms;

namespace ConnectiveSport
{
	public class SportButton : Button
	{
		public SportButton()
		{
			const int _animationTime = 100;
			Clicked += async (sender, e) =>
			{
				var btn = (SportButton)sender;
				await btn.ScaleTo(1.2, _animationTime);
				await btn.ScaleTo(1, _animationTime);
			};
		}
	}
}

