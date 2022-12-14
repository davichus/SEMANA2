using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dNavarreteS3
{
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            
            InitializeComponent(); 
            lblUsuario.Text = usuario; 
        }
    }
}

