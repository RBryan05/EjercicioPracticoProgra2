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
    }
}
