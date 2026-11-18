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
    public partial class FrmAltaVehiculo : Form
    {
        public FrmAltaVehiculo()
        {
            InitializeComponent();
            CargarProximoId();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var id = ObtenerUltimoId();
            string marca = string.IsNullOrEmpty(txtMarca.Text) ? "No se sabe" : txtMarca.Text;
            var modelo = txtModelo.Text;
            var matricula = txtMatricula.Text;
            var anio = (int)nudAnio.Value;
            Vehiculo vehiculo = new Vehiculo(id, marca, modelo, anio, matricula);
            GestorVehiculoDb gestor = new GestorVehiculoDb();
            gestor.AgregarVehiculo(vehiculo);
            LimpiarFormulario();
        }

        private int ObtenerUltimoId()
        {
            GestorVehiculoDb gestor = new GestorVehiculoDb();
            return gestor.ObtenerUltimoId(null);
        }

        private List<Vehiculo> LeerVehiculos()
        {
            GestorVehiculoDb gestor = new GestorVehiculoDb();
            return gestor.LeerVehiculos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void CargarProximoId()
        {
            txtIdVehiculo.Text = ObtenerUltimoId().ToString();
        }

        private void LimpiarFormulario()
        {
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            nudAnio.Value = DateTime.Now.Year;
            CargarProximoId();
        }

        private void BtnVerLista_Click(object sender, EventArgs e)
        {
            FrmListaVehiculo frmListaVehiculo = new FrmListaVehiculo();
            DialogResult result = frmListaVehiculo.ShowDialog();
        }
    }
}
