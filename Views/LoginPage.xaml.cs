using System;
using Microsoft.Maui.Controls;
using NovaVersaoCentralDocs.Views;

namespace NovaVersaoCentralDocs.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void Entrar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryLogin.Text) || string.IsNullOrWhiteSpace(EntrySenha.Text))
            {
                await DisplayAlert("Atenção", "Preencha todos os campo", "OK");
                return;
            }
            if (EntryLogin.Text == DadosUsuarios.EmailCadastrado && EntrySenha.Text == DadosUsuarios.SenhaCadastrada)
            {
                await Navigation.PushAsync(new TelaPrincipal());
            } else
            {
                await DisplayAlert("Erro", "E-mail ou senha incorretos.", "OK");
            }
            
        }

        public async void EsqueceuSenha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EsqueceuSenha());
        }

        public async void CadastreSe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());
        }
    }
}
