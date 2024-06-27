using System;
using System.Collections.Generic;

namespace FarmaciaUNIR.model
{
    public class Pedido
    {
        public string NombreMedicamento { get; set; }
        public string TipoMedicamento { get; set; }
        public long CantidadMedicamento { get; set; }
        public string NombreDistribuidor { get; set; }
        public List<string> Sucursal { get; set; }

        public Pedido(string nombreMedicamento, string tipoMedicamento, long cantidadMedicamento, string nombreDistribuidor, List<string> sucursal)
        {
            NombreMedicamento = nombreMedicamento;
            TipoMedicamento = tipoMedicamento;
            CantidadMedicamento = cantidadMedicamento;
            NombreDistribuidor = nombreDistribuidor;
            Sucursal = sucursal;
        }

        public Pedido()
        {
        }
    }
}
