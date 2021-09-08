using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaEnUnSoloForm
{
    public partial class Form1 : Form
    {

        var source = new BindingSource();
        List<Contacto> list = new List<MyStruct> { new MyStruct("fff", "b"), new MyStruct("c", "d") };
        source.DataSource = list;
        grid.DataSource = source;

        public Form1()
        {
            InitializeComponent();

            listaBinding = new BindingList<Contacto>(lista_contactos);
            dataGridView1.DataSource = listaBinding;

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Contacto c = new Contacto(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text);

            lista_contactos.Add(c);
        }
    }
}
