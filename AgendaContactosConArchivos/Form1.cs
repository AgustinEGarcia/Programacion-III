using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactosConArchivos
{
    public partial class Form_Principal : Form
    {
        public List<Contacto> lista_contactos = new List<Contacto>();

        

        string ruta = @"C:\Users\Agustin\Desktop\AgendaContactos.txt";

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void cargar_contactos()
        {
            //if (File.Exists(ruta))
            //{
            //    StreamReader sr = File.OpenText(ruta);

            //    while(sr.ReadLine() != null)
            //    {
            //        //Lista_contactos.Add(sr.ReadLine());
            //    }

            //    sr.Close();

            //    dataGridView1.DataSource = lista_contactos;

            //    return;
            //}

            //lista_contactos.Add(new Contacto("Agustin", "Garcia", "354"));
            //lista_contactos.Add(new Contacto("jere", "alvarez", "131"));

            dataGridView1.DataSource = lista_contactos;

        }

        public void actualizar()
        {
            dataGridView1.DataSource = lista_contactos;
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            //cargar_contactos();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            cargar_contactos();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            AgregarContacto ag = new AgregarContacto();

            ag.Lista_contactos = this.lista_contactos;

            ag.ShowDialog();

            this.lista_contactos = ag.Lista_contactos;

            actualizar();
        }
    }
}
