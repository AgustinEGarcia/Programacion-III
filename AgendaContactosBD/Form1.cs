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
    public partial class Form_principal : Form
    {
        public Form_principal()
        {
            InitializeComponent();
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            ConexionBD c = new ConexionBD();
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

        private int getId()
        {
            return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());

        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            int id = getId();

            EditarContacto edit = new EditarContacto(id);
            edit.ShowDialog();
            actualizar();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            int id = getId();

            try
            {
                  ConexionBD c = new ConexionBD();
                  c.eliminarContacto(id);
                  actualizar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error al eliminar en la BD " + ex.Message);
            }
        }
    }
}
