
namespace AgendaEnUnSoloForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_guardar_en_archivo = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_edicion_ap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.textBox_edicion_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_edicion_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_guardar_en_archivo
            // 
            this.button_guardar_en_archivo.Location = new System.Drawing.Point(281, 12);
            this.button_guardar_en_archivo.Name = "button_guardar_en_archivo";
            this.button_guardar_en_archivo.Size = new System.Drawing.Size(120, 23);
            this.button_guardar_en_archivo.TabIndex = 22;
            this.button_guardar_en_archivo.Text = "Guardar en archivo";
            this.button_guardar_en_archivo.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(187, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 23);
            this.button_eliminar.TabIndex = 21;
            this.button_eliminar.Text = "Eliminar contacto";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(93, 12);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(88, 23);
            this.button_editar.TabIndex = 20;
            this.button_editar.Text = "Editar contacto";
            this.button_editar.UseVisualStyleBackColor = true;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(12, 12);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 18;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(609, 84);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(183, 20);
            this.textBox_apellido.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apellido";
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(647, 134);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 29;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(609, 108);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(183, 20);
            this.textBox_telefono.TabIndex = 28;
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(559, 111);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 27;
            this.label_telefono.Text = "Teléfono";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(609, 59);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(183, 20);
            this.textBox_nombre.TabIndex = 26;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(559, 62);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 25;
            this.label_nombre.Text = "Nombre";
            // 
            // textBox_edicion_ap
            // 
            this.textBox_edicion_ap.Location = new System.Drawing.Point(609, 279);
            this.textBox_edicion_ap.Name = "textBox_edicion_ap";
            this.textBox_edicion_ap.Size = new System.Drawing.Size(183, 20);
            this.textBox_edicion_ap.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Apellido";
            // 
            // button_guardar
            // 
            this.button_guardar.Location = new System.Drawing.Point(647, 329);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(75, 23);
            this.button_guardar.TabIndex = 36;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.UseVisualStyleBackColor = true;
            // 
            // textBox_edicion_tel
            // 
            this.textBox_edicion_tel.Location = new System.Drawing.Point(609, 303);
            this.textBox_edicion_tel.Name = "textBox_edicion_tel";
            this.textBox_edicion_tel.Size = new System.Drawing.Size(183, 20);
            this.textBox_edicion_tel.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Teléfono";
            // 
            // textBox_edicion_nom
            // 
            this.textBox_edicion_nom.Location = new System.Drawing.Point(609, 254);
            this.textBox_edicion_nom.Name = "textBox_edicion_nom";
            this.textBox_edicion_nom.Size = new System.Drawing.Size(183, 20);
            this.textBox_edicion_nom.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 478);
            this.Controls.Add(this.textBox_edicion_ap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_guardar);
            this.Controls.Add(this.textBox_edicion_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_edicion_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.button_guardar_en_archivo);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_guardar_en_archivo;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_edicion_ap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.TextBox textBox_edicion_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_edicion_nom;
        private System.Windows.Forms.Label label4;
    }
}

