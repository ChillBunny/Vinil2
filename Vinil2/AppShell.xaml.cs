using Vinil2.ViewModels;
using Vinil2.Views;

namespace Vinil2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
        }
    }
}
