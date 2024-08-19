using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace EjercicioPractico
{
    public partial class RegistroPersonas : Form
    {
        ObtenerDatos _obtenerDatos;
        public RegistroPersonas()
        {
            _obtenerDatos = new ObtenerDatos();
            InitializeComponent();
            dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarPersona agregarPersona = new AgregarPersona();
            agregarPersona.ShowDialog();
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvPersons.Rows[e.RowIndex].Cells["businessEntityID"].Value.ToString());

                    if (dgvPersons.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarPersona objRegistroProducto = new AgregarPersona(id);
                        objRegistroProducto.ShowDialog();
                    }
                    else if (dgvPersons.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Personas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _obtenerDatos = new ObtenerDatos();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El registro se continua mostrando en el listado.", "Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _obtenerDatos.eliminarPersona(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("El registro eliminado con exito.", "Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
                            }
                            else
                            {
                                MessageBox.Show("No se logró eliminar el registro.", "Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex}");
            }
        }
    }
}
