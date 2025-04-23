namespace jgarcesS3.Views;

public partial class v2 : ContentPage
{
	public v2(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "Usuario Conectado: " + usuario;
    }

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.v3());
    }
}