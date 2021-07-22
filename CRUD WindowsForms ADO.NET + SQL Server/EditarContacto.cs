using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_WindowsForms_ADO.NET___SQL_Server
{
    public partial class EditarContacto : Form
    {
        private int? id;

        public EditarContacto(int? id = null)
        {
            InitializeComponent();
            this.id = id;

            if(this.id != null)
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            ConexionDB c = new ConexionDB();
            Contactos contacto = c.getContacto((int)id);
            textBox_nombre.Text = contacto.Nombre;
            textBox_telefono.Text = contacto.Telefono;
            textBox_mail.Text = contacto.Mail;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            ConexionDB c = new ConexionDB();

            try
            {
                c.editarContacto(textBox_nombre.Text, textBox_telefono.Text, textBox_mail.Text, (int)id);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
