namespace NovaVersaoCentralDocs.Views;

public partial class DocumentoPage : ContentPage
{
	public DocumentoPage()
	{
		InitializeComponent();
	}
	public async void OnVoltarTelaInicial(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TelaPrincipal());
    }
}