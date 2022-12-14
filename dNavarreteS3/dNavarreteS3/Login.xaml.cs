using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dNavarreteS3
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = "dnavarrete";
            string contrasena = "12345";
            if (usuario == txtUsuario.Text && contrasena == txtContrasena.Text)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario/Contraseña Incorrectos", "Cerrar");
            }
        }
    }
}

