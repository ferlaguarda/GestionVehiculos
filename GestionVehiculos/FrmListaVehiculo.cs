using Entities;
using Managers;
using System.ComponentModel;
using System.Data;

namespace GestionVehiculos
{
    public partial class FrmListaVehiculo : Form
    {
        public FrmListaVehiculo()
        {
            InitializeComponent();
            GestorVehiculoDb gestor = new GestorVehiculoDb();
            dataGridView1.DataSource = gestor.LeerVehiculos(); 
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor, seleccione un vehículo para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var vehiculo = dataGridView1.SelectedRows[0].DataBoundItem as Vehiculo;
            GestorVehiculoDb gestor = new GestorVehiculoDb();
            gestor.EliminarVehiculo(vehiculo.Id);
            dataGridView1.DataSource = gestor.LeerVehiculos();
            this.DialogResult = DialogResult.OK;
        }

        private void BTnActualizar_Click(object sender, EventArgs e)
        {
            if (!IsSelectedRowValid())
            {
                MessageBox.Show("Por favor, seleccione un vehículo para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var vehiculo = dataGridView1.SelectedRows[0].DataBoundItem as Vehiculo;
            FrmActualizarVehiculo frmActualizarVehiculo = new FrmActualizarVehiculo(vehiculo);
            DialogResult result = frmActualizarVehiculo.ShowDialog();
            if (result == DialogResult.OK)
            {
                GestorVehiculoDb gestor = new GestorVehiculoDb();
                dataGridView1.DataSource = gestor.LeerVehiculos();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private bool IsSelectedRowValid()
        {
            return dataGridView1.SelectedRows.Count > 0;
        }
    }
}
