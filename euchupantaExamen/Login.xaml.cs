using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace euchupantaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

       
    

      
        async void btnNo_Clicked_1(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Cerra", "Desea Cerrar la aplicación?", "Si", "No");
            if (answer)
            {
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;
            
         

            if ((Usuario == "estudiante2023") && (Contraseña == "uisrael2023"))
            {
                Navigation.PushAsync(new Registro(Usuario,Contraseña));
            }
            else
            {
                DisplayAlert("Alerta", "Dato incorrecto", "OK");
            }
        }
    }
}