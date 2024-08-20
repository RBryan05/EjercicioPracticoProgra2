using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            _obtenerDatos = new ObtenerDatos();
            dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvPersons.Rows[e.RowIndex].Cells["businessEntityID"].Value.ToString());

                    if (dgvPersons.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Registro Personas",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _obtenerDatos = new ObtenerDatos();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El registro se continua mostrando en el listado.", "Registro Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _obtenerDatos.EliminarPersona(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("El registro eliminado con exito.", "Registro Personas",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
                            }
                            else
                            {
                                MessageBox.Show("No se logró eliminar el registro.", "Registro Personas",
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _obtenerDatos = new ObtenerDatos();
            string nombre = tbNombre.Text;
            if (nombre != "")
            {
                dgvPersons.DataSource = _obtenerDatos.Filtrar(nombre);
            }
            else
            {
                dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                _obtenerDatos = new ObtenerDatos();
                int businessEntity = int.Parse(txtBuscar.Text);
                var persona = _obtenerDatos.ObtenerPorID(businessEntity);

                if (persona != null)
                {
                    txtPersonType.Text = persona.PersonType;
                    ckbNameStyle.Checked = persona.NameStyle;
                    txtTitle.Text = persona.Title.ToString();
                    txtFirstName.Text = persona.FirstName;
                    txtMiddleName.Text = persona.MiddleName;
                    txtLastName.Text = persona.LastName;
                    txtSuffix.Text = persona.Suffix.ToString();
                    txtEmailPromotion.Text = persona.EmailPromotion.ToString();
                    txtAdditionalContactInfo.Text = persona.AdditionalContactInfo?.ToString();
                    txtDemographics.Text = persona.Demographics;
                    txtRowguid.Text = persona.Rowguid.ToString();
                    dtpFechaModificacion.Value = persona.ModifiedDate;
                }
                else
                {
                    // Manejar el caso donde no se encontró la persona
                    MessageBox.Show("No se encontró una persona con el BusinessEntityID proporcionado.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
            }
            catch (Exception ex)
            {
                // Capturar y mostrar cualquier otro error que ocurra
                MessageBox.Show("Sucedió un error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtPersonType.Text = string.Empty;
            ckbNameStyle.Checked = false;
            txtTitle.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSuffix.Text = string.Empty;
            txtEmailPromotion.Text = string.Empty;
            txtAdditionalContactInfo.Text = string.Empty;
            txtDemographics.Text = string.Empty;
            txtRowguid.Text = string.Empty;
            dtpFechaModificacion.Value = DateTime.Now;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                _obtenerDatos = new ObtenerDatos();

                int BusinessEntityID = int.Parse(txtBuscar.Text);
                string personType = txtPersonType.Text;
                bool nameStyle = ckbNameStyle.Checked;
                string title = txtTitle.Text;
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;
                string suffix = txtSuffix.Text;
                int emailPromotion = int.Parse(txtEmailPromotion.Text);

                _obtenerDatos.AgregarBusinessEntityID();

                string mensaje = _obtenerDatos.AgregarPersona(BusinessEntityID, personType, nameStyle, title, firstName, middleName, lastName, suffix, emailPromotion);


                if (mensaje == "true")
                {
                    MessageBox.Show("Persona agregada exitosamente", "Registro Personas");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show($"Ocurrio un error {mensaje}", "Registro Personas");
                }

            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente");
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                _obtenerDatos = new ObtenerDatos();

                int BusinessEntityID = int.Parse(txtBuscar.Text);
                string personType = txtPersonType.Text;
                bool nameStyle = ckbNameStyle.Checked;
                string title = txtTitle.Text;
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;
                string suffix = txtSuffix.Text;
                int emailPromotion = int.Parse(txtEmailPromotion.Text);

                int mensaje = _obtenerDatos.EditarRegistro(BusinessEntityID, personType, nameStyle, title, firstName, middleName, lastName, suffix, emailPromotion);


                if (mensaje > 0)
                {
                    MessageBox.Show("Persona editada exitosamente", "Registro Personas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show($"Ocurrio un error {mensaje}", "Registro Personas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente.", "Registro Persona",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtBuscar.Text);

                var desicion = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Registro Persona",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                _obtenerDatos = new ObtenerDatos();

                int resultado = 0;

                if (desicion != DialogResult.Yes)
                {
                    MessageBox.Show("El registro se continua mostrando en el listado.", "Registro Persona",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    resultado = _obtenerDatos.EliminarPersona(id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("El registro eliminado con exito.", "Registro Persona",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPersons.DataSource = _obtenerDatos.ObtenerPersonas();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se logró eliminar el registro.", "Registro Persona",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingrese los datos correctamente.", "Registro Persona",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
