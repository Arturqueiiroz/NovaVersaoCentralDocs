namespace NovaVersaoCentralDocs.Views;

public partial class InformacoesPerfil : ContentPage
{
	public InformacoesPerfil()
	{
		InitializeComponent();
	}
    public async void MenuPrincipal(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipalUsuario());
    }
    public async void Dados(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InformacoesPerfil());
    }
    public async void Documentos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DocumentosUsuarios());
    }
    public async void Sair(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
    public async void Perfil(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PerfilPage());
    }
}