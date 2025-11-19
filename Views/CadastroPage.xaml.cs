using System.Net.Http.Json;
using Microsoft.Maui.Controls;

namespace NovaVersaoCentralDocs.Views;

public partial class CadastroPage : ContentPage
{
    private readonly string apiUrl = "https://localhost:7279/api/Account";

    public CadastroPage()
    {
        InitializeComponent();
    }

    public async void Entrar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntryNome.Text) ||
            string.IsNullOrWhiteSpace(EntryEmail.Text) ||
            string.IsNullOrWhiteSpace(EntrySenhaa.Text) ||
            string.IsNullOrWhiteSpace(EntryConfirme.Text))
        {
            await DisplayAlert("Atenção", "Preencha todos os campos!", "OK");
            return;
        }
        if (EntrySenhaa.Text != EntryConfirme.Text)
        {
            await DisplayAlert("Erro", "As senhas não conferem!", "OK");
            return;
        }


        var novoUsuario = new
        {
            NomeCompleto = EntryNome.Text,
            Email = EntryEmail.Text,
            PassWordHash = EntrySenhaa.Text
        };

        try
        {
            using var client = new HttpClient();
            var response = await client.PostAsJsonAsync($"{apiUrl}/register", novoUsuario);

            if (response.IsSuccessStatusCode)
            {
                await Navigation.PushAsync(new TermosDeUsoPage());
            }
            else
            {
                var erro = await response.Content.ReadAsStringAsync();
                await DisplayAlert("Erro", $"Falha no cadastro:\n{erro}", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Erro ao conectar com o servidor:\n{ex.Message}", "OK");
        }
    }

    public async void Voltar(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
