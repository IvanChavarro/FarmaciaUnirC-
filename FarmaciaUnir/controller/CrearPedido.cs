using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using FarmaciaUnir.view;

namespace FarmaciaUNIR
{
    public class Pedido
    {
        public string NombreDistribuidor { get; set; }
        public long CantidadMedicamento { get; set; }
        public string TipoMedicamento { get; set; }
        public string NombreMedicamento { get; set; }
        public List<string> Sucursal { get; set; }
    }

    public class GenerarPedido
    {
        private readonly string DIR_PRINCIPAL = "Calle de la Rosa n. 28";
        private readonly string DIR_SECUNDARIA = "Calle Alcazabilla n.3";

        private static readonly string SUCURSAL_PRINCIPAL = "Principal";
        private static readonly string SUCURSAL_SECUNDARIA = "Secundaria";

        public void CrearPedido(Pedido dto)
        {
            string direccion;
            if (dto.Sucursal.Count > 1)
            {
                direccion = DIR_PRINCIPAL + " y para la situada en " + DIR_SECUNDARIA;
            }
            else if (dto.Sucursal[0].Equals("principal", StringComparison.OrdinalIgnoreCase))
            {
                direccion = DIR_PRINCIPAL;
            }
            else
            {
                direccion = DIR_SECUNDARIA;
            }

            var resumenPedido = new ResumenPedidoForm(dto.NombreDistribuidor, dto.CantidadMedicamento, dto.TipoMedicamento, dto.NombreMedicamento, direccion)
            {
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Confirmar pedido",
                //Icon = new Icon("path/to/unirPharmacy.ico"),
                MaximizeBox = false
            };

            resumenPedido.ShowDialog();
        }

        public static bool ValidarDatosIngresados(string medicamento, string cantidad, ButtonGroup bg, bool sucursalPrincipal, bool sucursalSecundaria, ComboBox tipoMedicamentoComboBox)
        {
            if (string.IsNullOrWhiteSpace(medicamento) || string.IsNullOrWhiteSpace(cantidad) || bg.SelectedButton == null || (!sucursalPrincipal && !sucursalSecundaria) || cantidad.Equals("0"))
            {
                return false;
            }
            else
            {
                var sucursal = new List<string>();
                if (sucursalPrincipal)
                {
                    sucursal.Add(SUCURSAL_PRINCIPAL);
                }
                if (sucursalSecundaria)
                {
                    sucursal.Add(SUCURSAL_SECUNDARIA);
                }

                var pedido = new Pedido
                {
                    NombreMedicamento = medicamento,
                    TipoMedicamento = tipoMedicamentoComboBox.SelectedItem.ToString(),
                    CantidadMedicamento = long.Parse(cantidad),
                    Sucursal = sucursal
                };

                pedido.NombreDistribuidor = bg.SelectedButton.Text;

                var generarPedido = new GenerarPedido();
                generarPedido.CrearPedido(pedido);
            }
            return true;
        }
    }

    public class ButtonGroup
    {
        private List<RadioButton> buttons = new List<RadioButton>();

        public RadioButton SelectedButton
        {
            get
            {
                return buttons.FirstOrDefault(b => b.Checked);
            }
        }

        public void Add(RadioButton button)
        {
            buttons.Add(button);
            button.CheckedChanged += (sender, args) =>
            {
                if (button.Checked)
                {
                    foreach (var btn in buttons.Where(b => b != button))
                    {
                        btn.Checked = false;
                    }
                }
            };
        }

        public IEnumerable<RadioButton> Buttons => buttons;
    }

   
}
