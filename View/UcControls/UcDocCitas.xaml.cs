using Integrador2017.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1.View.UcControls
{
    /// <summary>
    /// Lógica de interacción para UcDocCitas.xaml
    /// </summary>
    public partial class UcDocCitas : UserControl
    {
        ControllerCita CC = new ControllerCita();

        public UcDocCitas()
        {
            InitializeComponent();
        }

        private void btnRegresar(object sender, RoutedEventArgs e)
        {
            //WpfApplication1.View.WindowAdministrador u = new WindowAdministrador();//Ventana que se va a mostrar
            // u.Show();
            //Window.GetWindow(this).Close();//Ventana que se va a cerrar
            switch (WpfApplication1.NavegacionValidar.a)
            {
                case 1:
                    WindowAdministrador Admin = new WindowAdministrador();
                    Admin.Show();
                    Window.GetWindow(this).Close();//Ventana que se va a cerrar
                    break;
                case 2:
                    WindowDoctor Doct = new WindowDoctor();
                    Doct.Show();
                    Window.GetWindow(this).Close();//Ventana que se va a cerrar
                    break;
                case 3:
                    WindowSecretaria secre = new WindowSecretaria();
                    secre.Show();
                    Window.GetWindow(this).Close();//Ventana que se va a cerrar
                    break;


            }
        }


        private void btnBuscarCita_Click(object sender, RoutedEventArgs e)
        {
            dtgbusCita.ItemsSource = CC.BusCita(txtNombreCita.Text);
        }
    }
}
