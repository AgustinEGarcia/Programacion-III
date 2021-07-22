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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button_conectarBD_Click(object sender, EventArgs e)
        {
            ConexionDB c1 = new ConexionDB();

            if (c1.pruebaConexion())
            {
                MessageBox.Show("La conexión fue exitosa", "Prueba de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se conectó a la BD", "Prueba de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizar()
        {
            ConexionDB c = new ConexionDB();
            dataGridView1.DataSource = c.getContactos();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            AgregarContacto ag = new AgregarContacto();
            ag.ShowDialog();
            actualizar();
        }

        private int? getId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            int? id = getId();

            if(id != null)
            {
                EditarContacto edit = new EditarContacto(id);
                edit.ShowDialog();
                actualizar();
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            int? id = getId();

            try
            {
                if (id != null)
                {
                    ConexionDB c = new ConexionDB();
                    c.eliminarContacto((int)id);
                    actualizar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al eliminar en la BD " + ex.Message);
            }

            
        }
    }
}
