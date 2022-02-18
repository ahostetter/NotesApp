namespace NotesApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new MainPage();
		MainPage = new NavigationPage(new MainPage());
	}
}
