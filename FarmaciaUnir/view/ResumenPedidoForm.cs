using System;
using System.Drawing;
using System.Windows.Forms;

namespace FarmaciaUnir.view
{
    public partial class ResumenPedidoForm : Form
    {
        public ResumenPedidoForm(string distribuidor, long unidades, string tipoMedicamento, string nombreMedicamento, string direccionFarmacia)
        {
            // Establecer el título de la ventana
            Text = "Pedido al distribuidor " + distribuidor;

            // Inicializar componentes de la interfaz
            getPedido(distribuidor, unidades, tipoMedicamento, nombreMedicamento, direccionFarmacia);
            InitializeComponent();
            
        }

    }
}
