using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactosConArchivos
{
    public partial class AgregarContacto : Form
    {
        private List<Contacto> lista_contactos = new List<Contacto>();
        public List<Contacto> Lista_contactos { get => lista_contactos; set => lista_contactos = value; }
        
        public AgregarContacto()
        {
            InitializeComponent();

        }


        private void button_agregar_Click(object sender, EventArgs e)
        {

            Contacto c = new Contacto(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text);

            Lista_contactos.Add(c);

            this.Close();
        }
    }
}
