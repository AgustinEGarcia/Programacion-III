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
        Form_Principal f;

        public AgregarContacto(Form_Principal f)
        {
            InitializeComponent();

            this.f = f;
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {

            Contacto c = new Contacto(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text);

            f.lista_contactos.Add(c);
            f.actualizar();


            this.Close();
        }
    }
}
