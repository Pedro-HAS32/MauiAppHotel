namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void btn_sobre_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new Sobre();
    }
}