namespace GestionVehiculos
{
    partial class FrmAltaVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMarca = new TextBox();
            txtMatricula = new TextBox();
            txtModelo = new TextBox();
            BtnGuardar = new Button();
            nudAnio = new NumericUpDown();
            label1 = new Label();
            BtnCancelar = new Button();
            label2 = new Label();
            txtIdVehiculo = new TextBox();
            BtnVerLista = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(52, 80);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca del vehiculo";
            txtMarca.Size = new Size(289, 27);
            txtMarca.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(52, 146);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Ingrese la matricula";
            txtMatricula.Size = new Size(289, 27);
            txtMatricula.TabIndex = 1;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(52, 218);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo del vehiculo";
            txtModelo.Size = new Size(289, 27);
            txtModelo.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(232, 322);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(109, 41);
            BtnGuardar.TabIndex = 3;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(186, 269);
            nudAnio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1930, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(155, 27);
            nudAnio.TabIndex = 3;
            nudAnio.TextAlign = HorizontalAlignment.Right;
            nudAnio.Value = new decimal(new int[] { 1930, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 269);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "Año del vehículo:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(117, 322);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(109, 41);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 38);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "Id vehículo:";
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Enabled = false;
            txtIdVehiculo.Location = new Point(216, 38);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(125, 27);
            txtIdVehiculo.TabIndex = 7;
            // 
            // BtnVerLista
            // 
            BtnVerLista.Location = new Point(236, 399);
            BtnVerLista.Name = "BtnVerLista";
            BtnVerLista.Size = new Size(105, 26);
            BtnVerLista.TabIndex = 8;
            BtnVerLista.Text = "Ver lista";
            BtnVerLista.UseVisualStyleBackColor = true;
            BtnVerLista.Click += BtnVerLista_Click;
            // 
            // FrmAltaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(BtnVerLista);
            Controls.Add(txtIdVehiculo);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(label1);
            Controls.Add(nudAnio);
            Controls.Add(BtnGuardar);
            Controls.Add(txtModelo);
            Controls.Add(txtMatricula);
            Controls.Add(txtMarca);
            Name = "FrmAltaVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de Vehiculo";
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtMatricula;
        private TextBox txtModelo;
        private Button BtnGuardar;
        private NumericUpDown nudAnio;
        private Label label1;
        private Button BtnCancelar;
        private Label label2;
        private TextBox txtIdVehiculo;
        private Button BtnVerLista;
    }
}