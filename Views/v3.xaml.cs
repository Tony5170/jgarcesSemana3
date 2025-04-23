namespace jgarcesS3.Views;

public partial class v3 : ContentPage
{
	public v3()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuarioc = txtUsuario.Text;
        string contrasenac = txtContrasena.Text;
		DisplayAlert("Alerta", "Usuario almacenado", "OK");
		Navigation.PushAsync(new Views.v1(usuarioc, contrasenac));
    }
}