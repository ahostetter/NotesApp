namespace NotesApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void Navigate(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HelloXamlPage());
    }
}

