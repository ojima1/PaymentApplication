namespace PaymentApplication.Pages;

public partial class LoginPage : ContentPage
{

    public static string EMAIL { get; set; }

    public LoginPage()
	{
		InitializeComponent();

		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        EMAIL = one.Text;



		Navigation.PushModalAsync(new DashBoard());
    }
}