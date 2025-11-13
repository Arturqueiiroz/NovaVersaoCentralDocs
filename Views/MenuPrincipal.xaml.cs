namespace NovaVersaoCentralDocs.Views;

public partial class MenuPrincipal : ContentPage
{
    public MenuPrincipal()
    {
        InitializeComponent();
    }

    private void OnSuporteClicked(object sender, EventArgs e)

    {

        AtualizarConteudo("Área de Suporte");

    }

    private void OnConfiguracoesClicked(object sender, EventArgs e)

    {

        AtualizarConteudo("Configurações do Sistema");

    }

    private void OnAcessibilidadeClicked(object sender, EventArgs e)

    {

        AtualizarConteudo("Opções de Acessibilidade");

    }

    private void OnSobreClicked(object sender, EventArgs e)

    {

        AtualizarConteudo("Informações sobre a empresa");

    }

    private void OnFaqClicked(object sender, EventArgs e)

    {

        AtualizarConteudo("Perguntas Frequentes (FAQ)");

    }

    private void AtualizarConteudo(string texto)

    {

        var conteudo = this.FindByName<VerticalStackLayout>("ConteudoArea");

        if (conteudo != null)

        {

            conteudo.Children.Clear();

            conteudo.Children.Add(new Label

            {

                Text = texto,

                FontSize = 18,

                TextColor = Colors.Black

            });

        }

    }

}
