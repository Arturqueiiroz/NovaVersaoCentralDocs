using System;
using Microsoft.Maui.Controls;
using NovaVersaoCentralDocs.Views;

namespace NovaVersaoCentralDocs.Views;

public partial class CadastroPage : ContentPage
{

	public CadastroPage()
	{
		InitializeComponent();
	}
	public async void Entrar(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(EntryNome.Text) || string.IsNullOrWhiteSpace(EntryCpf.Text) || string.IsNullOrWhiteSpace(EntryEmail.Text) || string.IsNullOrWhiteSpace(EntrySenhaa.Text) || string.IsNullOrWhiteSpace(EntryConfirme.Text))
		{
			await DisplayAlert("Atenção", "Preencha todos os campo", "OK");
			return;
		}
		if (EntrySenhaa.Text != EntryConfirme.Text)
		{
			await DisplayAlert("Erro", "As senhas não conferem", "OK'");
		}
		DadosUsuarios.EmailCadastrado = EntryEmail.Text;
		DadosUsuarios.SenhaCadastrada = EntrySenhaa.Text;
		await Navigation.PushAsync(new TermosDeUsoPage());
	}
	public async void Voltar(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}