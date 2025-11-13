using System.Collections.ObjectModel;

namespace NovaVersaoCentralDocs.Views;

public partial class TelaPrincipal : ContentPage
{
    public ObservableCollection<Documento> DocumentosRecentes { get; set; }
    public TelaPrincipal()
	{
		InitializeComponent();
        DocumentosRecentes = new ObservableCollection<Documento>
        {
            new Documento { Nome = "Carteira de Identidade Nacional", Info = "Última visualização: 05/11/2025", Icon = "icon_id.png" },
            new Documento { Nome = "CNH", Info = "Válido até: 12/2025", Icon = "icon_cnh.png" }
        };

        BindingContext = this;
    }
    public class Documento
    {
        public string Nome { get; set; }
        public string Info { get; set; }
        public string Icon { get; set; }
    }

    public async void Acessibilidade(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AcessibilidadePage());
    }
    public async void Perfil(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PerfilPage());
    }
    public async void Documentos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DocumentoPage());
    }
    public async void MenuPrincipla(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MenuPrincipal());
    }
}