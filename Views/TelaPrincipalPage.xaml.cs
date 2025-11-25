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
    private void Pesquisar(object sender, EventArgs e)
    {
        string termo = BarraDePesquisa.Text;

        if (string.IsNullOrWhiteSpace(termo))
        {
            return;
        }

        // Aqui você decide o que quer fazer com o termo
        DisplayAlert("Busca", $"Você pesquisou por: {termo}", "OK");

        // Se quiser filtrar os documentos exibidos:
        // var filtrados = ViewModel.DocumentosRecentes
        //     .Where(d => d.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase))
        //     .ToList();
        // 
        // CollectionViewDocumentos.ItemsSource = filtrados;

        // Ou navegar para uma página de resultados:
        // await Navigation.PushAsync(new PaginaResultados(termo));
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
    public async void TermosDeUso(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TermosDeUsoPage());
    }
}