namespace GestionVehiculos
{
    partial class FrmListaVehiculo
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
            dataGridView1 = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colMatricula = new DataGridViewTextBoxColumn();
            colModelo = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            BTnActualizar = new Button();
            BtnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colId, colMarca, colMatricula, colModelo, colAnio });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Nr.";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colMarca
            // 
            colMarca.DataPropertyName = "Marca";
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            colMarca.Width = 125;
            // 
            // colMatricula
            // 
            colMatricula.DataPropertyName = "Matricula";
            colMatricula.HeaderText = "Matricula";
            colMatricula.MinimumWidth = 6;
            colMatricula.Name = "colMatricula";
            colMatricula.ReadOnly = true;
            colMatricula.Width = 125;
            // 
            // colModelo
            // 
            colModelo.DataPropertyName = "Modelo";
            colModelo.HeaderText = "Modelo";
            colModelo.MinimumWidth = 6;
            colModelo.Name = "colModelo";
            colModelo.ReadOnly = true;
            colModelo.Width = 125;
            // 
            // colAnio
            // 
            colAnio.DataPropertyName = "Anio";
            colAnio.HeaderText = "Año";
            colAnio.MinimumWidth = 6;
            colAnio.Name = "colAnio";
            colAnio.ReadOnly = true;
            colAnio.Width = 125;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BTnActualizar);
            splitContainer1.Panel2.Controls.Add(BtnEliminar);
            splitContainer1.Size = new Size(676, 325);
            splitContainer1.SplitterDistance = 267;
            splitContainer1.TabIndex = 1;
            // 
            // BTnActualizar
            // 
            BTnActualizar.Location = new Point(440, 5);
            BTnActualizar.Name = "BTnActualizar";
            BTnActualizar.Size = new Size(109, 37);
            BTnActualizar.TabIndex = 1;
            BTnActualizar.Text = "Actualizar";
            BTnActualizar.UseVisualStyleBackColor = true;
            BTnActualizar.Click += BTnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(555, 5);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(109, 37);
            BtnEliminar.TabIndex = 0;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // FrmListaVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 325);
            Controls.Add(splitContainer1);
            Name = "FrmListaVehiculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehiculos registrados";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colMatricula;
        private DataGridViewTextBoxColumn colModelo;
        private DataGridViewTextBoxColumn colAnio;
        private SplitContainer splitContainer1;
        private Button BtnEliminar;
        private Button BTnActualizar;
    }
}