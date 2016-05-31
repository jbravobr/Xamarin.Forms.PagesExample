using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamDataPagesExample
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();
		}

		void ListDataPage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new FirstPage());
		}

		void HeroImage_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new SecondPage());
		}

		void ListItem_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new ThirdPage());
		}

		void CardView_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new FourthPage());
		}
	}
}

