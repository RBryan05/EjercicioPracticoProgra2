using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPractico
{
    public partial class AgregarPersona : Form
    {
        ObtenerDatos _obtenerDatos;
        public AgregarPersona()
        {
            InitializeComponent();            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _obtenerDatos = new ObtenerDatos();


                int BusinessEntityID = int.Parse(businessEntityIDTextBox.Text);
                string personType = personTypeTextBox.Text;
                bool nameStyle = nameStyleCheckBox.Checked;
                string title = titleTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string middleName = middleNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string suffix = suffixTextBox.Text;
                int emailPromotion = int.Parse(emailPromotionTextBox.Text);

                _obtenerDatos.AgregarBusinessEntityID();

            string mensaje = _obtenerDatos.AgregarPersona(BusinessEntityID, personType, nameStyle, title, firstName, middleName, lastName, suffix, emailPromotion);


                if (mensaje == "true")
                {
                    MessageBox.Show("Persona agregada exitosamente", "Registro Personas");
                }
                else
                {
                    MessageBox.Show($"Ocurrio un error {mensaje}", "Registro Personas");
                }

            
        }
    }
}
