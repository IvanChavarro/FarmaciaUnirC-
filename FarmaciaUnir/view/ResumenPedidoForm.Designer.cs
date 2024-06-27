using FarmaciaUnir.Properties;
using FarmaciaUNIR;
using System.Windows.Forms;

namespace FarmaciaUnir.view
{
    partial class ResumenPedidoForm
    {
        string distribuidor; long unidades; string tipoMedicamento; string nombreMedicamento; string direccionFarmacia;

        public void getPedido(string distribuidor, long unidades, string tipoMedicamento, string nombreMedicamento, string direccionFarmacia)
        {
            this.distribuidor = distribuidor;
            this.unidades = unidades;
            this.tipoMedicamento = tipoMedicamento;
            this.nombreMedicamento = nombreMedicamento;
            this.direccionFarmacia = direccionFarmacia;
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResumenPedidoForm));
            jPanel1 = new Panel();
            medicamentoLabel = new Label();
            tipoMedicamentoLabel = new Label();
            cantidadLabel = new Label();
            distribuidorLabel = new Label();
            sucursalLabel = new Label();
            cancelarBtn = new Button();
            enviarBtn = new Button();
            codigoBarras = new PictureBox();
            jPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // jPanel1
            // 
            jPanel1.BackColor = Color.FromArgb(201, 201, 201);
            jPanel1.Controls.Add(medicamentoLabel);
            jPanel1.Controls.Add(tipoMedicamentoLabel);
            jPanel1.Controls.Add(cantidadLabel);
            jPanel1.Controls.Add(distribuidorLabel);
            jPanel1.Controls.Add(sucursalLabel);
            jPanel1.Controls.Add(cancelarBtn);
            jPanel1.Controls.Add(enviarBtn);
            jPanel1.Controls.Add(codigoBarras);
            jPanel1.Dock = DockStyle.Fill;
            jPanel1.Location = new Point(0, 0);
            jPanel1.Name = "jPanel1";
            jPanel1.Size = new Size(413, 414);
            jPanel1.TabIndex = 0;
            // 
            // medicamentoLabel
            // 
            medicamentoLabel.AutoSize = true;
            medicamentoLabel.ForeColor = Color.Black;
            medicamentoLabel.Location = new Point(109, 30);
            medicamentoLabel.Name = "medicamentoLabel";
            medicamentoLabel.Text = "Medicamento " + nombreMedicamento;
            medicamentoLabel.Size = new Size(0, 15);
            medicamentoLabel.TabIndex = 2;
            // 
            // tipoMedicamentoLabel
            // 
            tipoMedicamentoLabel.AutoSize = true;
            tipoMedicamentoLabel.ForeColor = Color.Black;
            tipoMedicamentoLabel.Location = new Point(109, 90);
            tipoMedicamentoLabel.Name = "tipoMedicamentoLabel";
            tipoMedicamentoLabel.Text = "Tipo de medicamento " + tipoMedicamento;
            tipoMedicamentoLabel.Size = new Size(0, 15);
            tipoMedicamentoLabel.TabIndex = 3;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.ForeColor = Color.Black;
            cantidadLabel.Location = new Point(109, 150);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Text = "Unidades " + unidades;
            cantidadLabel.Size = new Size(0, 15);
            cantidadLabel.TabIndex = 4;
            // 
            // distribuidorLabel
            // 
            distribuidorLabel.AutoSize = true;
            distribuidorLabel.ForeColor = Color.Black;
            distribuidorLabel.Location = new Point(109, 210);
            distribuidorLabel.Name = "distribuidorLabel";
            distribuidorLabel.Text = "Distribuidor " + distribuidor;
            distribuidorLabel.Size = new Size(0, 15);
            distribuidorLabel.TabIndex = 6;
            // 
            // sucursalLabel
            // 
            sucursalLabel.AutoSize = true;
            sucursalLabel.ForeColor = Color.Black;
            sucursalLabel.Location = new Point(109, 270);
            sucursalLabel.Name = "sucursalLabel";
            sucursalLabel.Text = "Sucursal " + direccionFarmacia;
            sucursalLabel.Size = new Size(0, 15);
            sucursalLabel.TabIndex = 10;
            // 
            // cancelarBtn
            // 
            cancelarBtn.Location = new Point(84, 379);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(109, 23);
            cancelarBtn.TabIndex = 13;
            cancelarBtn.Text = "CANCELAR";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // enviarBtn
            // 
            enviarBtn.Location = new Point(214, 379);
            enviarBtn.Name = "enviarBtn";
            enviarBtn.Size = new Size(109, 23);
            enviarBtn.TabIndex = 13;
            enviarBtn.Text = "ENVIAR";
            enviarBtn.UseVisualStyleBackColor = true;
            enviarBtn.Click += enviarBtn_Click;
            // 
            // codigoBarras
            // 
            codigoBarras.Image = Resources.codigoBarras;
            codigoBarras.Location = new Point(71, 299);
            codigoBarras.Name = "codigoBarras";
            codigoBarras.Size = new Size(271, 74);
            codigoBarras.SizeMode = PictureBoxSizeMode.StretchImage;
            codigoBarras.TabIndex = 14;
            codigoBarras.TabStop = false;
            // 
            // ResumenPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 414);
            Controls.Add(jPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ResumenPedidoForm";
            Text = "RegistroPedidoFrame";
            jPanel1.ResumeLayout(false);
            jPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)codigoBarras).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido enviado satisfactoriamente", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Console.WriteLine("Pedido enviado");
            cancelarBtn_Click(sender, e);
        }


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel jPanel1;
        private System.Windows.Forms.Label medicamentoLabel;
        private System.Windows.Forms.Label tipoMedicamentoLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label distribuidorLabel;
        private System.Windows.Forms.Label sucursalLabel;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.Button enviarBtn;
        private System.Windows.Forms.PictureBox codigoBarras;

    }
}
