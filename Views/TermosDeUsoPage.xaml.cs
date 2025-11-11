namespace NovaVersaoCentralDocs.Views;

public partial class TermosDeUsoPage : ContentPage
{
	public TermosDeUsoPage()
	{
		InitializeComponent();
	}
    public async void AceitarTermos(object sender, EventArgs e)
    {
        await DisplayAlert("Sucesso", "Cadastro concluído com sucesso!", "OK");
        await Navigation.PushAsync(new LoginPage());
    }

    public async void RecusarTermos(object sender, EventArgs e)
    {
        await DisplayAlert("Aviso", "Você precisa aceitar os termos para continuar.", "OK");
        return;
    }
}
