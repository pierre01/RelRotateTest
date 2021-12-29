using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace RelRotateTest
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			robotImg.AnchorX = 0.5;
			robotImg.AnchorY = 0.5;
			robotImg.RelRotateTo(45, 250, Easing.CubicOut);
		}
	}
}
