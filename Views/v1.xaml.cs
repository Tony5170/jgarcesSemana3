namespace jgarcesS3.Views;

public partial class v1 : ContentPage
{
	public v1()
	{
		InitializeComponent();
	}
    string usuariof = " ";
    string contrasenaf = " ";
    public v1(string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuariof && txtContrasena.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.v2(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "OK");
        }

    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.v3());
    }
}