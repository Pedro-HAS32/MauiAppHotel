using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        //O <Quarto> significa que o código está usando o modelo criado na pasta "Models".
        //O código na primeira linha diz para o aplicativo usar o modelo "Quarto" dentro da pasta models
        //O código abaixo cria uma nova lista chamada "lista_quartos" que usa o modelo <Quarto>.
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suite Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suite Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suite Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }

        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState) //O "?" no "IActivationState" Indica que o valor pode ser nulo!
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600; //Largura inícial da janela
            window.Height = 600; //Altura inícial da janela

            window.MinimumWidth = 400; //Largura miníma da janela
            window.MinimumHeight = 600; //Altura miníma da janela

            return window;
        }

    }
}
