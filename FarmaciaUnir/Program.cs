using FarmaciaUnir.view;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace FarmaciaUnir
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            RegistroPedidoFrame registroPedidoFrame = new RegistroPedidoFrame();

            registroPedidoFrame.StartPosition = FormStartPosition.CenterScreen;
            registroPedidoFrame.MaximizeBox = false;
            registroPedidoFrame.MinimizeBox = false;
            registroPedidoFrame.Text = "Registrar pedido";

            try
            {
                // Obtener el stream del recurso del icono desde el ensamblado
                using (var stream = typeof(Program).Assembly.GetManifestResourceStream("FarmaciaUnir.resources.images.unirPharmacy.png"))
                {
                    if (stream != null)
                    {
                        // Crear un objeto Icon desde el stream
                        registroPedidoFrame.Icon = new Icon(stream);
                    }
                    else
                    {
                        Console.WriteLine("Icono no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el icono: " + ex.Message);
            }

            //ResumenPedidoForm resumenPedidoForm = new ResumenPedidoForm("Distribuidor", 12l, "tipoMedicamento", "nombreMedicamento", "primera");
            Application.Run(registroPedidoFrame);
            //Application.Run(resumenPedidoForm);
        }
    }
}
