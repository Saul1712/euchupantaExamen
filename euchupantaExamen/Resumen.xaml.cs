using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace euchupantaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario1, string nombre1, string pago)
        {
            InitializeComponent();
            //string usuario;
            //lblusuario.Text = usuario;
            lblusuario.Text = usuario1;
            txtNombre.Text = nombre1;
            txtPagoTotal.Text = pago;


        }
    }
}