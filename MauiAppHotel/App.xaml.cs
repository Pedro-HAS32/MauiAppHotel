
namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState) //O "?" no "IActivationState" Indica que o valor pode ser nulo!
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400; //Largura inícial da janela
            window.Height = 600; //Altura inícial da janela

            window.MinimumWidth = 400; //Largura miníma da janela
            window.MinimumHeight = 600; //Altura miníma da janela

            return window;
        }

    }
}
