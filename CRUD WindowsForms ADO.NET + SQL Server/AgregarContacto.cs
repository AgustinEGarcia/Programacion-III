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
    public partial class AgregarContacto : Form
    {
        public AgregarContacto()
        {
            InitializeComponent();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            ConexionDB c = new ConexionDB();

            try
            {
                c.nuevoContacto(textBox_nombre.Text, textBox_telefono.Text, textBox_mail.Text);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message);
            }

            
        }
    }
}
