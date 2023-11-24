using PaymentApplication.Pages;

namespace PaymentApplication;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new RegistrationPage();
	}
}
