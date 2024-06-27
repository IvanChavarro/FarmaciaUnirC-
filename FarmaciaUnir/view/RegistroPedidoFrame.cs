using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FarmaciaUNIR;

namespace FarmaciaUnir.view
{
    public partial class RegistroPedidoFrame : Form
    {
        public Pedido pedido;
        private ButtonGroup bg;

        public RegistroPedidoFrame()
        {
            if (pedido == null)
            {
                pedido = new Pedido();
            }
            this.bg = new ButtonGroup();
            InitializeComponent();

            // Agregar al ComboBox los items a escoger
            List<string> tiposMedicamentos = new List<string> { "Analgésico", "Analéptico", "Anestésico", "Antiácido", "Antidepresivo", "Antibióticos" };
            tiposMedicamentos.Sort();
            tipoMedicamentoComboBox.Items.AddRange(tiposMedicamentos.ToArray());
            if (tipoMedicamentoComboBox.Items.Count > 0)
            {
                tipoMedicamentoComboBox.SelectedIndex = 0;
            }


            // Agregar los RadioButtons al ButtonGroup para seleccionar solo uno
            bg.Add(distriCofarma);
            bg.Add(distriEmpsephar);
            bg.Add(distriCemefar);

            this.registrarPedido.Text = this.registrarPedido.Text.ToUpper();
        }

        private void cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void medicamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            ResetComponents(this);
        }

        private void confirmarBtn_Click(object sender, EventArgs e)
        {
            if (!GenerarPedido.ValidarDatosIngresados(medicamento.Text, cantidad.Text, bg, sucursalPrincipal.Checked, sucursalSecundaria.Checked, tipoMedicamentoComboBox))
            {
                MessageBox.Show("Verifique el formulario, campos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetComponents(Control container)
        {
            foreach (Control component in container.Controls)
            {
                if (component is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (component is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (component is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (component is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }
                else if (component.HasChildren)
                {
                    ResetComponents(component);
                }
            }
        }
    }
}
