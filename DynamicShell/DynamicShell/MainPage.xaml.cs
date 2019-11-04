using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicShell
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void Button_Clicked(object sender, EventArgs e)
		{
			var mainPage = new FlyoutItem
			{
				Title = "Main Page",
				Items =
				{
					new ShellContent
					{
						Content = new MainPage()
					}
				}
			};

			var page1 = new FlyoutItem
			{
				Title = "Page 1",
				Items =
				{
					new ShellContent
					{
						Content = new Page1()
					}
				}
			};
			Shell.Current.Items.Clear();
			Shell.Current.Items.Add(page1);
			Shell.Current.Items.Add(mainPage);
		}
	}
}
