using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Vinil2
{
    public partial class MainPage : ContentPage
    {

        private readonly IFingerprint fingerprint;

        public MainPage()
        {
            InitializeComponent();
            this.fingerprint = CrossFingerprint.Current;
        }
        private async void OnFingerClicked(object sender, EventArgs e)
        {

            var hasBiometric = await fingerprint.GetAvailabilityAsync();
            var bioType = await fingerprint.GetAuthenticationTypeAsync();

            if (hasBiometric==FingerprintAvailability.Available)
            {
                var request = new AuthenticationRequestConfiguration("Biometric Auth!", $"use {bioType} to grant access");
                    var result = await fingerprint.AuthenticateAsync(request);
                    if(result.Authenticated)
                {
                    await DisplayAlert("Authenticated!","Access granted","ok");
                }
                else
                {
                    await DisplayAlert("Not authenticated!", "Access granted", "ok");
                }
            }
            else
            {
                await DisplayAlert("No Access", "Acceso denied", "OK");
            }
           


        }
    }
}