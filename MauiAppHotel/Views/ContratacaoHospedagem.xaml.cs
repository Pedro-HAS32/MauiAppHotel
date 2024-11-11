namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        //Descobrir o que o código abaixo faz
        PropriedadesApp = (App)Application.Current;

        //pck_quarto é o nome dado ao picker de data no ContratacaoHospedam.xaml
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        //Define uma data minima e uma data máxima para ser escolhida
        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

    }

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new Sobre();
    }

    // |-----------------> Anotar! <-----------------|
    // |Fazer nota sobre o funcionamento do Try/Catch|
    // |---------------------------------------------|

    //Troca de tela com animação
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        } catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddDays(6);
    }
}