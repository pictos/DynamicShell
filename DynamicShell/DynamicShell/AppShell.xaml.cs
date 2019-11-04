using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicShell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
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

			Items.Add(mainPage);
			Items.Add(page1);
		}
	}
}