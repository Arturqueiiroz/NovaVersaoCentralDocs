namespace NovaVersaoCentralDocs.Views;

public partial class AcessibilidadePage : ContentPage
{
	public AcessibilidadePage()
	{
		InitializeComponent();
	}
	public async void OnVoltarTelaInicial(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TelaPrincipal());
    }
}