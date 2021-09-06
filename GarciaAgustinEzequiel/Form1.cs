using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GarciaAgustinEzequiel
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();
        string[] arregloLista;

        public Form1()
        {
            InitializeComponent();
        }


        private void separar_elementos()
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            lista = arregloLista.ToList();

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem + "     ");
            }

        }

        

        private void separar_elementos_nuevo_caracter()
        {
            string cont_textBox = textBox_entrada.Text;

            string separador_salida = textBox_caracSalida.Text;

            string separador_entrada = textBox_caracEntrada.Text;

            string result = cont_textBox.Replace(separador_entrada, separador_salida);

            arregloLista = result.Split(separador_salida[0]);

            lista = arregloLista.ToList();

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem);
                textBox_salida.AppendText(separador_salida[0].ToString());
            }
        }

        private void button_separar_Click(object sender, EventArgs e)
        {
            separar_elementos();
        }

        private void button_transformar_Click(object sender, EventArgs e)
        {
            separar_elementos_nuevo_caracter();
        }

        private void ordenarListaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            List<string> aux;

            aux = arregloLista.ToList();

            aux.Sort();

            lista = aux;

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem);
                textBox_salida.AppendText(separador[0].ToString());
            }

        }

        private void invertirListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            lista = arregloLista.ToList();

            lista.Reverse();

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem);
                textBox_salida.AppendText(separador[0].ToString());
            }
        }

        private void mayúsculaAMinúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            lista = arregloLista.ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] = lista[i].ToLower();
            }

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem);
                textBox_salida.AppendText(separador[0].ToString());
            }
        }

        private void minúsculaAMayúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            lista = arregloLista.ToList();

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] = lista[i].ToUpper();
            }

            textBox_salida.Text = "";

            foreach (string elem in lista)
            {
                textBox_salida.AppendText(elem);
                textBox_salida.AppendText(separador[0].ToString());
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cont_textBox = textBox_entrada.Text;

            string separador = textBox_caracEntrada.Text;

            arregloLista = cont_textBox.Split(separador[0]);

            lista = arregloLista.ToList();


            FileInfo f = new FileInfo(Application.StartupPath);
            FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            using(StreamWriter writter = new StreamWriter(fs))
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    writter.WriteLine(lista[i]);

                }
            }

            MessageBox.Show("Archivo guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            fs.Close();
        }

        private void cargarArchivo()
        {
            FileInfo f = new FileInfo(Application.StartupPath);
            FileStream fs = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string tope = null;
            int i = 0;

            while ((tope = sr.ReadLine()) != null)
            {
                arregloLista[i] = tope;
                i++;
            }

            lista = arregloLista.ToList();

            textBox_entrada.Text = lista.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cargarArchivo();
        }

        
    }
}
