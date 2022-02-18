namespace NotesApp;

public partial class HelloXamlPage : ContentPage
{
	int count = 0;

	public HelloXamlPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}
}