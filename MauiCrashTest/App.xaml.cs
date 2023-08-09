using MauiCrashTest.Src.Views;

namespace MauiCrashTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new TestView();
	}
}
