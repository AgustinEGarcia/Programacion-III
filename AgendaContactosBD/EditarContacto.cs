using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactosBD
{
    public partial class EditarContacto : Form
    {
        private int id;

        public EditarContacto(int id)
        {
            InitializeComponent();
            this.id = id;

            cargarDatos();
        }

        private void cargarDatos()
        {
            ConexionBD c = new ConexionBD();
            Contacto contacto = c.getContacto(id);
            textBox_nombre.Text = contacto.Nombre;
            textBox_apellido.Text = contacto.Apellido;
            textBox_telefono.Text = contacto.Telefono;
            textBox_mail.Text = contacto.Mail;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            ConexionBD c = new ConexionBD();

            try
            {
                c.editarContacto(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_mail.Text, id);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }
    }
}
