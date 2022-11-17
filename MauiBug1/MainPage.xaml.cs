namespace MauiBug1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ToggleButtonVisible(object sender, EventArgs e)
    {
        VisibleButton.IsVisible = !VisibleButton.IsVisible;
        InvisibleButton.IsVisible = !InvisibleButton.IsVisible;
    }
}