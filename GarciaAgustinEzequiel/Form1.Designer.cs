
namespace GarciaAgustinEzequiel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_entrada = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarListaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayúsculaAMinúsculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minúsculaAMayúsculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_caracEntrada = new System.Windows.Forms.TextBox();
            this.textBox_caracSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_transformar = new System.Windows.Forms.Button();
            this.button_separar = new System.Windows.Forms.Button();
            this.textBox_salida = new System.Windows.Forms.TextBox();
            this.guardarListaOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarListaModificadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_entrada
            // 
            this.textBox_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_entrada.Location = new System.Drawing.Point(15, 40);
            this.textBox_entrada.Multiline = true;
            this.textBox_entrada.Name = "textBox_entrada";
            this.textBox_entrada.Size = new System.Drawing.Size(485, 165);
            this.textBox_entrada.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.ordenarListaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarListaOriginalToolStripMenuItem,
            this.guardarListaModificadaToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.guardarToolStripMenuItem.Text = "Guardar en archivo";
            // 
            // ordenarListaToolStripMenuItem
            // 
            this.ordenarListaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarListaToolStripMenuItem1,
            this.invertirListaToolStripMenuItem,
            this.mayúsculaAMinúsculaToolStripMenuItem,
            this.minúsculaAMayúsculaToolStripMenuItem});
            this.ordenarListaToolStripMenuItem.Name = "ordenarListaToolStripMenuItem";
            this.ordenarListaToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ordenarListaToolStripMenuItem.Text = "Lista";
            // 
            // ordenarListaToolStripMenuItem1
            // 
            this.ordenarListaToolStripMenuItem1.Name = "ordenarListaToolStripMenuItem1";
            this.ordenarListaToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.ordenarListaToolStripMenuItem1.Text = "Ordenar lista";
            this.ordenarListaToolStripMenuItem1.Click += new System.EventHandler(this.ordenarListaToolStripMenuItem1_Click);
            // 
            // invertirListaToolStripMenuItem
            // 
            this.invertirListaToolStripMenuItem.Name = "invertirListaToolStripMenuItem";
            this.invertirListaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.invertirListaToolStripMenuItem.Text = "Invertir lista";
            this.invertirListaToolStripMenuItem.Click += new System.EventHandler(this.invertirListaToolStripMenuItem_Click);
            // 
            // mayúsculaAMinúsculaToolStripMenuItem
            // 
            this.mayúsculaAMinúsculaToolStripMenuItem.Name = "mayúsculaAMinúsculaToolStripMenuItem";
            this.mayúsculaAMinúsculaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mayúsculaAMinúsculaToolStripMenuItem.Text = "Mayúscula a minúscula";
            this.mayúsculaAMinúsculaToolStripMenuItem.Click += new System.EventHandler(this.mayúsculaAMinúsculaToolStripMenuItem_Click);
            // 
            // minúsculaAMayúsculaToolStripMenuItem
            // 
            this.minúsculaAMayúsculaToolStripMenuItem.Name = "minúsculaAMayúsculaToolStripMenuItem";
            this.minúsculaAMayúsculaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.minúsculaAMayúsculaToolStripMenuItem.Text = "Minúscula a mayúscula";
            this.minúsculaAMayúsculaToolStripMenuItem.Click += new System.EventHandler(this.minúsculaAMayúsculaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caracter entrada:";
            // 
            // textBox_caracEntrada
            // 
            this.textBox_caracEntrada.Location = new System.Drawing.Point(612, 57);
            this.textBox_caracEntrada.Name = "textBox_caracEntrada";
            this.textBox_caracEntrada.Size = new System.Drawing.Size(100, 20);
            this.textBox_caracEntrada.TabIndex = 4;
            // 
            // textBox_caracSalida
            // 
            this.textBox_caracSalida.Location = new System.Drawing.Point(612, 83);
            this.textBox_caracSalida.Name = "textBox_caracSalida";
            this.textBox_caracSalida.Size = new System.Drawing.Size(100, 20);
            this.textBox_caracSalida.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caracter salida:";
            // 
            // button_transformar
            // 
            this.button_transformar.Location = new System.Drawing.Point(718, 83);
            this.button_transformar.Name = "button_transformar";
            this.button_transformar.Size = new System.Drawing.Size(75, 23);
            this.button_transformar.TabIndex = 7;
            this.button_transformar.Text = "Transformar";
            this.button_transformar.UseVisualStyleBackColor = true;
            this.button_transformar.Click += new System.EventHandler(this.button_transformar_Click);
            // 
            // button_separar
            // 
            this.button_separar.Location = new System.Drawing.Point(718, 58);
            this.button_separar.Name = "button_separar";
            this.button_separar.Size = new System.Drawing.Size(75, 23);
            this.button_separar.TabIndex = 8;
            this.button_separar.Text = "Separar";
            this.button_separar.UseVisualStyleBackColor = true;
            this.button_separar.Click += new System.EventHandler(this.button_separar_Click);
            // 
            // textBox_salida
            // 
            this.textBox_salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_salida.Location = new System.Drawing.Point(12, 299);
            this.textBox_salida.Multiline = true;
            this.textBox_salida.Name = "textBox_salida";
            this.textBox_salida.Size = new System.Drawing.Size(485, 165);
            this.textBox_salida.TabIndex = 9;
            // 
            // guardarListaOriginalToolStripMenuItem
            // 
            this.guardarListaOriginalToolStripMenuItem.Name = "guardarListaOriginalToolStripMenuItem";
            this.guardarListaOriginalToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.guardarListaOriginalToolStripMenuItem.Text = "Guardar lista original";
            this.guardarListaOriginalToolStripMenuItem.Click += new System.EventHandler(this.guardarListaOriginalToolStripMenuItem_Click);
            // 
            // guardarListaModificadaToolStripMenuItem
            // 
            this.guardarListaModificadaToolStripMenuItem.Name = "guardarListaModificadaToolStripMenuItem";
            this.guardarListaModificadaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.guardarListaModificadaToolStripMenuItem.Text = "Guardar lista modificada";
            this.guardarListaModificadaToolStripMenuItem.Click += new System.EventHandler(this.guardarListaModificadaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 505);
            this.Controls.Add(this.textBox_salida);
            this.Controls.Add(this.button_separar);
            this.Controls.Add(this.button_transformar);
            this.Controls.Add(this.textBox_caracSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_caracEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_entrada);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_entrada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_caracEntrada;
        private System.Windows.Forms.TextBox textBox_caracSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_transformar;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Button button_separar;
        private System.Windows.Forms.ToolStripMenuItem ordenarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarListaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invertirListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayúsculaAMinúsculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minúsculaAMayúsculaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_salida;
        private System.Windows.Forms.ToolStripMenuItem guardarListaOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarListaModificadaToolStripMenuItem;
    }
}

