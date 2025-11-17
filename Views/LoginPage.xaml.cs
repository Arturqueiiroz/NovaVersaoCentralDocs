using System.Net.Http.Json;
using Microsoft.Maui.Controls;

namespace NovaVersaoCentralDocs.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly string apiUrl = "https://localhost:7279/api/Account";

        public LoginPage()
        {
            InitializeComponent();
        }

        public async void Entrar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryLogin.Text) ||
                string.IsNullOrWhiteSpace(EntrySenha.Text))
            {
                await DisplayAlert("Atenção", "Preencha todos os campos!", "OK");
                return;
            }

            var loginData = new
            {
                Email = EntryLogin.Text,
                PassWordHash = EntrySenha.Text
            };

            try
            {
                using var client = new HttpClient();
                var response = await client.PostAsJsonAsync($"{apiUrl}/login", loginData);

                if (response.IsSuccessStatusCode)
                {
                    await Navigation.PushAsync(new TelaPrincipal());
                }
                else
                {
                    await DisplayAlert("Erro", "E-mail ou senha incorretos.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Falha ao conectar com a API:\n{ex.Message}", "OK");
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
