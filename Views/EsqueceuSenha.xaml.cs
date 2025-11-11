using Microsoft.Maui.Controls;
using NovaVersaoCentralDocs.Views;
using System;

namespace NovaVersaoCentralDocs.Views;

public partial class EsqueceuSenha : ContentPage
{
	public EsqueceuSenha()
	{
		InitializeComponent();
	}
    public async void Voltar(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(EntryEmail.Text))
        {
            await DisplayAlert("Atenção", "Preencha o campo determinado!", "OK");
            return;
        }
        await Navigation.PushAsync(new LoginPage());
    }
}
