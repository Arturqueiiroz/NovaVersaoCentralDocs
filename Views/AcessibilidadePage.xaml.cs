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
    public async void MenuPrincipla(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipal());
    }
    public void Pesquisar(object sender, EventArgs e)
    {
        string termo = BarraDePesquisa.Text;

        if (string.IsNullOrWhiteSpace(termo))
        {
            return;
        }

        DisplayAlert("Busca", $"Você pesquisou por: {termo}", "OK");
    }
}