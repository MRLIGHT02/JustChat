using System.Threading.Tasks;

namespace SocialApp.Pages;

public partial class OnBoardingPage : ContentPage
{
    public OnBoardingPage()
    {
        InitializeComponent();
    }



    private async void goToLoginPage_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}