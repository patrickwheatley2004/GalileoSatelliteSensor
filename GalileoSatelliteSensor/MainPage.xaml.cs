namespace GalileoSatelliteSensor;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;


		Random randy = new Random();
		int R = randy.Next(0, 255);
		int G = randy.Next(0, 255);
		int B = randy.Next(0, 255);

		CounterBtn.BackgroundColor = Color.FromRgb(R, G, B);	

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

