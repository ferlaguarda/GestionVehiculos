namespace GestionVehiculos
{
    partial class FrmActualizarVehiculo
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
            txtIdVehiculo = new TextBox();
            label2 = new Label();
            BtnCancelar = new Button();
            label1 = new Label();
            nudAnio = new NumericUpDown();
            BtnGuardar = new Button();
            txtModelo = new TextBox();
            txtMatricula = new TextBox();
            txtMarca = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            SuspendLayout();
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Enabled = false;
            txtIdVehiculo.Location = new Point(213, 25);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(125, 27);
            txtIdVehiculo.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 25);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 16;
            label2.Text = "Id vehículo:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(114, 309);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(109, 41);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 256);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 14;
            label1.Text = "Año del vehículo:";
            // 
            // nudAnio
            // 
            nudAnio.Location = new Point(183, 256);
            nudAnio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1930, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(155, 27);
            nudAnio.TabIndex = 12;
            nudAnio.TextAlign = HorizontalAlignment.Right;
            nudAnio.Value = new decimal(new int[] { 1930, 0, 0, 0 });
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(229, 309);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(109, 41);
            BtnGuardar.TabIndex = 13;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(49, 205);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo del vehiculo";
            txtModelo.Size = new Size(289, 27);
            txtModelo.TabIndex = 11;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(49, 133);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Ingrese la matricula";
            txtMatricula.Size = new Size(289, 27);
            txtMatricula.TabIndex = 10;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(49, 67);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca del vehiculo";
            txtMarca.Size = new Size(289, 27);
            txtMarca.TabIndex = 9;
            // 
            // FrmActualizarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 383);
            Controls.Add(txtIdVehiculo);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(label1);
            Controls.Add(nudAnio);
            Controls.Add(BtnGuardar);
            Controls.Add(txtModelo);
            Controls.Add(txtMatricula);
            Controls.Add(txtMarca);
            Name = "FrmActualizarVehiculo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Actualización de vehículo";
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdVehiculo;
        private Label label2;
        private Button BtnCancelar;
        private Label label1;
        private NumericUpDown nudAnio;
        private Button BtnGuardar;
        private TextBox txtModelo;
        private TextBox txtMatricula;
        private TextBox txtMarca;
    }
}