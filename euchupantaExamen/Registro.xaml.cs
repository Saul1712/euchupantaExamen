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
    public partial class Registro : ContentPage
    {
        private int valorCurso = 3000;
        private int valorCursoInicial = 1000;
        private int valorCursoSaldo = 0;
        private int mesesDiferido = 3;
        private int valorCuota = 0;
        private decimal valorInteres = 0.5m;
        private decimal valorCuotaFinal = 0;
        public Registro(string usuario, string nombre)
        {
            InitializeComponent();
            
            lblusuario.Text = usuario;
            txtMonto.Text = "1000";
            valorCursoSaldo = valorCurso - valorCursoInicial;
            valorCuota = valorCursoSaldo/3;
            valorCuotaFinal=valorCuota+((valorCuota*valorInteres)/100);

            //llenar input
            txtMontoSaldo.Text = valorCursoSaldo.ToString();
            txtPagoMensual.Text= valorCuotaFinal.ToString();
            txtMeses.Text = mesesDiferido.ToString();
            //txtNombre.Text = nombre;

        }
        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int montoI = int.Parse(txtMonto.Text);
            int pagoM = int.Parse(txtPagoMensual.Text);

            //P = 

            //if ()
            //{

            //}





        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
           string usuario1 = lblusuario.Text;
            string nombre2 = txtNombre.Text;
            Navigation.PushAsync(new Resumen(usuario1, nombre2));
        }
        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(txtMonto.Text);
                if (numero <  0 || numero > 3000)
                {
                    DisplayAlert("Mensaje", "El rango permitido es de 0 y 3000 ", "Cerrar");
                    txtMonto.Text = "";
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }
        }
    }
}