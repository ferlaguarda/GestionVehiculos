using Entities;
using Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionVehiculos
{
    public partial class FrmActualizarVehiculo : Form
    {
        public FrmActualizarVehiculo(Vehiculo vehiculo)
        {
            InitializeComponent();
            txtIdVehiculo.Text = vehiculo.Id.ToString();
            txtMarca.Text = vehiculo.Marca;
            txtModelo.Text = vehiculo.Modelo;
            txtMatricula.Text = vehiculo.Matricula;
            nudAnio.Value = vehiculo.Anio;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtIdVehiculo.Text);
            string marca = string.IsNullOrEmpty(txtMarca.Text) ? "No se sabe" : txtMarca.Text;
            var modelo = txtModelo.Text;
            var matricula = txtMatricula.Text;
            var anio = (int)nudAnio.Value;
            Vehiculo vehiculo = new Vehiculo(id, marca, modelo, anio, matricula);
            GestorVehiculoDb  gestor = new GestorVehiculoDb();
            gestor.ActualizarVehiculo(vehiculo);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
