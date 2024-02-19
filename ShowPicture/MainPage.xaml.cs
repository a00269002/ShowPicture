namespace ShowPicture;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
    /*(private void Button1Clicked(object sender, EventArgs e)
   {
       DisplayImage("Picture1.png");
   }*/

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            status.ImageSource = ImageSource.FromFile("picture.png");
        }
        catch (Exception ex)
        {
            // Handle any exceptions (e.g., file not found)
            Console.WriteLine($"Error loading image: {ex.Message}");
        }
    }

    /*private void Button2Clicked(object sender, EventArgs e)
    {
        UpdateLabel("Button 2 clicked");
    }

    private void Button3Clicked(object sender, EventArgs e)
    {
        UpdateLabel("Button 3 clicked");
    }

    private void UpdateLabel(string text)
    {
        textToShowing.Text = text;
    }

    private void DisplayImage(string inputPicture)
    {
        // Picture stored in the Resources folder
        string pathPicture = $"MyMauiApp.Resources.{inputPicture}";

        // Load the image from resources
        var assembly = typeof(MainPage).Assembly;
        var imageSource = ImageSource.FromResource(pathPicture, assembly);

        // Display the image
        imageDisplay.Source = imageSource;
    }*/

}


