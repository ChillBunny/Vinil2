using System.Runtime.CompilerServices;
using Plugin.Fingerprint.Abstractions;

namespace Vinil.Views;

public partial class LoginView : ContentPage
{
	private readonly IFingerprint fingerprint;
	public LoginView()
	{

		InitializeComponent();
		this.fingerprint = fingerprint;


	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
		var request = new AuthenticationRequestConfiguration("Validaremos la huella", "Porque sn ellos no podras ingresar");
		var result = await fingerprint.AuthenticateAsync(request);
		if (result.Authenticated) 
		{
			await DisplayAlert("Autenticado!", "Acceso autorizado", "OK");
		}
		else
		{
			await DisplayAlert("Sin Acceso", "Acceso denegado", "OK");
		}

    }
}