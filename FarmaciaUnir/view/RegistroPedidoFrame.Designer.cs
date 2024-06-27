using FarmaciaUNIR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FarmaciaUnir.view
{
    partial class RegistroPedidoFrame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel jPanel1;
        private System.Windows.Forms.TextBox medicamento;
        private System.Windows.Forms.Label medicamentoLabel;
        private System.Windows.Forms.Label tipoMedicamentoLabel;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label distribuidorLabel;
        private System.Windows.Forms.RadioButton distriCofarma;
        private System.Windows.Forms.RadioButton distriEmpsephar;
        private System.Windows.Forms.RadioButton distriCemefar;
        private System.Windows.Forms.Label sucursalLabel;
        private System.Windows.Forms.CheckBox sucursalPrincipal;
        private System.Windows.Forms.CheckBox sucursalSecundaria;
        private System.Windows.Forms.Button borrarBtn;
        private System.Windows.Forms.Button confirmarBtn;
        private System.Windows.Forms.Label registrarPedido;
        private System.Windows.Forms.ComboBox tipoMedicamentoComboBox;
        private System.Windows.Forms.Panel jPanel2;
        private System.Windows.Forms.PictureBox logoUnir;
        private ButtonGroup buttonGroup1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPedidoFrame));
            jPanel1 = new Panel();
            medicamento = new TextBox();
            medicamentoLabel = new Label();
            tipoMedicamentoLabel = new Label();
            cantidadLabel = new Label();
            cantidad = new TextBox();
            distribuidorLabel = new Label();
            distriCofarma = new RadioButton();
            distriEmpsephar = new RadioButton();
            distriCemefar = new RadioButton();
            sucursalLabel = new Label();
            sucursalPrincipal = new CheckBox();
            sucursalSecundaria = new CheckBox();
            borrarBtn = new Button();
            confirmarBtn = new Button();
            registrarPedido = new Label();
            tipoMedicamentoComboBox = new ComboBox();
            jPanel2 = new Panel();
            logoUnir = new PictureBox();
            jPanel1.SuspendLayout();
            jPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoUnir).BeginInit();
            SuspendLayout();
            // 
            // jPanel1
            // 
            jPanel1.BackColor = Color.FromArgb(0, 108, 187);
            jPanel1.Controls.Add(medicamento);
            jPanel1.Controls.Add(medicamentoLabel);
            jPanel1.Controls.Add(tipoMedicamentoLabel);
            jPanel1.Controls.Add(cantidadLabel);
            jPanel1.Controls.Add(cantidad);
            jPanel1.Controls.Add(distribuidorLabel);
            jPanel1.Controls.Add(distriCofarma);
            jPanel1.Controls.Add(distriEmpsephar);
            jPanel1.Controls.Add(distriCemefar);
            jPanel1.Controls.Add(sucursalLabel);
            jPanel1.Controls.Add(sucursalPrincipal);
            jPanel1.Controls.Add(sucursalSecundaria);
            jPanel1.Controls.Add(borrarBtn);
            jPanel1.Controls.Add(confirmarBtn);
            jPanel1.Controls.Add(registrarPedido);
            jPanel1.Controls.Add(tipoMedicamentoComboBox);
            jPanel1.Controls.Add(jPanel2);
            jPanel1.Dock = DockStyle.Fill;
            jPanel1.Location = new Point(0, 0);
            jPanel1.Name = "jPanel1";
            jPanel1.Size = new Size(800, 450);
            jPanel1.TabIndex = 0;
            // 
            // medicamento
            // 
            medicamento.ForeColor = Color.FromArgb(0, 108, 187);
            medicamento.Location = new Point(31, 96);
            medicamento.Name = "medicamento";
            medicamento.Size = new Size(375, 23);
            medicamento.TabIndex = 1;
            medicamento.KeyPress += medicamento_KeyPress;
            // 
            // medicamentoLabel
            // 
            medicamentoLabel.AutoSize = true;
            medicamentoLabel.ForeColor = Color.White;
            medicamentoLabel.Location = new Point(31, 75);
            medicamentoLabel.Name = "medicamentoLabel";
            medicamentoLabel.Size = new Size(147, 15);
            medicamentoLabel.TabIndex = 2;
            medicamentoLabel.Text = "Nombre del medicamento";
            // 
            // tipoMedicamentoLabel
            // 
            tipoMedicamentoLabel.AutoSize = true;
            tipoMedicamentoLabel.ForeColor = Color.White;
            tipoMedicamentoLabel.Location = new Point(31, 144);
            tipoMedicamentoLabel.Name = "tipoMedicamentoLabel";
            tipoMedicamentoLabel.Size = new Size(123, 15);
            tipoMedicamentoLabel.TabIndex = 3;
            tipoMedicamentoLabel.Text = "Tipo de medicamento";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.ForeColor = Color.White;
            cantidadLabel.Location = new Point(31, 212);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new Size(108, 15);
            cantidadLabel.TabIndex = 4;
            cantidadLabel.Text = "Cantidad requerida";
            // 
            // cantidad
            // 
            cantidad.ForeColor = Color.FromArgb(0, 108, 187);
            cantidad.Location = new Point(31, 230);
            cantidad.Name = "cantidad";
            cantidad.Size = new Size(375, 23);
            cantidad.TabIndex = 5;
            cantidad.KeyPress += cantidad_KeyPress;
            // 
            // distribuidorLabel
            // 
            distribuidorLabel.AutoSize = true;
            distribuidorLabel.ForeColor = Color.White;
            distribuidorLabel.Location = new Point(31, 287);
            distribuidorLabel.Name = "distribuidorLabel";
            distribuidorLabel.Size = new Size(69, 15);
            distribuidorLabel.TabIndex = 6;
            distribuidorLabel.Text = "Distribuidor";
            // 
            // distriCofarma
            // 
            distriCofarma.AutoSize = true;
            distriCofarma.ForeColor = Color.White;
            distriCofarma.Location = new Point(31, 305);
            distriCofarma.Name = "distriCofarma";
            distriCofarma.Size = new Size(71, 19);
            distriCofarma.TabIndex = 7;
            distriCofarma.TabStop = true;
            distriCofarma.Text = "Cofarma";
            distriCofarma.UseVisualStyleBackColor = true;
            // 
            // distriEmpsephar
            // 
            distriEmpsephar.AutoSize = true;
            distriEmpsephar.ForeColor = Color.White;
            distriEmpsephar.Location = new Point(104, 305);
            distriEmpsephar.Name = "distriEmpsephar";
            distriEmpsephar.Size = new Size(84, 19);
            distriEmpsephar.TabIndex = 8;
            distriEmpsephar.TabStop = true;
            distriEmpsephar.Text = "Empsephar";
            distriEmpsephar.UseVisualStyleBackColor = true;
            // 
            // distriCemefar
            // 
            distriCemefar.AutoSize = true;
            distriCemefar.ForeColor = Color.White;
            distriCemefar.Location = new Point(191, 305);
            distriCemefar.Name = "distriCemefar";
            distriCemefar.Size = new Size(70, 19);
            distriCemefar.TabIndex = 9;
            distriCemefar.TabStop = true;
            distriCemefar.Text = "Cemefar";
            distriCemefar.UseVisualStyleBackColor = true;
            // 
            // sucursalLabel
            // 
            sucursalLabel.AutoSize = true;
            sucursalLabel.ForeColor = Color.White;
            sucursalLabel.Location = new Point(31, 345);
            sucursalLabel.Name = "sucursalLabel";
            sucursalLabel.Size = new Size(51, 15);
            sucursalLabel.TabIndex = 10;
            sucursalLabel.Text = "Sucursal";
            // 
            // sucursalPrincipal
            // 
            sucursalPrincipal.AutoSize = true;
            sucursalPrincipal.ForeColor = Color.White;
            sucursalPrincipal.Location = new Point(31, 363);
            sucursalPrincipal.Name = "sucursalPrincipal";
            sucursalPrincipal.Size = new Size(72, 19);
            sucursalPrincipal.TabIndex = 11;
            sucursalPrincipal.Text = "Principal";
            sucursalPrincipal.UseVisualStyleBackColor = true;
            // 
            // sucursalSecundaria
            // 
            sucursalSecundaria.AutoSize = true;
            sucursalSecundaria.ForeColor = Color.White;
            sucursalSecundaria.Location = new Point(108, 363);
            sucursalSecundaria.Name = "sucursalSecundaria";
            sucursalSecundaria.Size = new Size(84, 19);
            sucursalSecundaria.TabIndex = 12;
            sucursalSecundaria.Text = "Secundaria";
            sucursalSecundaria.UseVisualStyleBackColor = true;
            // 
            // borrarBtn
            // 
            borrarBtn.Location = new Point(104, 400);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(109, 23);
            borrarBtn.TabIndex = 13;
            borrarBtn.Text = "BORRAR";
            borrarBtn.UseVisualStyleBackColor = true;
            borrarBtn.Click += borrarBtn_Click;
            // 
            // confirmarBtn
            // 
            confirmarBtn.Location = new Point(259, 400);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(109, 23);
            confirmarBtn.TabIndex = 14;
            confirmarBtn.Text = "CONFIRMAR";
            confirmarBtn.UseVisualStyleBackColor = true;
            confirmarBtn.Click += confirmarBtn_Click;
            // 
            // registrarPedido
            // 
            registrarPedido.AutoSize = true;
            registrarPedido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            registrarPedido.ForeColor = Color.White;
            registrarPedido.Location = new Point(31, 21);
            registrarPedido.Name = "registrarPedido";
            registrarPedido.Size = new Size(188, 25);
            registrarPedido.TabIndex = 15;
            registrarPedido.Text = "REGISTRAR PEDIDO";
            // 
            // tipoMedicamentoComboBox
            // 
            tipoMedicamentoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoMedicamentoComboBox.ForeColor = Color.FromArgb(0, 108, 187);
            tipoMedicamentoComboBox.FormattingEnabled = true;
            tipoMedicamentoComboBox.Location = new Point(31, 162);
            tipoMedicamentoComboBox.Name = "tipoMedicamentoComboBox";
            tipoMedicamentoComboBox.Size = new Size(375, 23);
            tipoMedicamentoComboBox.TabIndex = 16;
            // 
            // jPanel2
            // 
            jPanel2.BackColor = Color.White;
            jPanel2.Controls.Add(logoUnir);
            jPanel2.Location = new Point(431, 0);
            jPanel2.Name = "jPanel2";
            jPanel2.Size = new Size(368, 450);
            jPanel2.TabIndex = 17;
            // 
            // logoUnir
            // 
            logoUnir.Image = Properties.Resources.unirPharmacy;
            logoUnir.Location = new Point(70, 96);
            logoUnir.Margin = new Padding(3, 2, 3, 2);
            logoUnir.Name = "logoUnir";
            logoUnir.Size = new Size(234, 227);
            logoUnir.SizeMode = PictureBoxSizeMode.StretchImage;
            logoUnir.TabIndex = 0;
            logoUnir.TabStop = false;
            // 
            // RegistroPedidoFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(jPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistroPedidoFrame";
            Text = "RegistroPedidoFrame";
            jPanel1.ResumeLayout(false);
            jPanel1.PerformLayout();
            jPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoUnir).EndInit();
            ResumeLayout(false);
        }
    }
}
