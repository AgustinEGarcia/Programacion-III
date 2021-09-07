
namespace AgendaContactosConArchivos
{
    partial class Form_Principal
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
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_guardar_en_archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(280, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(88, 23);
            this.button_eliminar.TabIndex = 15;
            this.button_eliminar.Text = "Eliminar contacto";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(186, 12);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(88, 23);
            this.button_editar.TabIndex = 14;
            this.button_editar.Text = "Editar contacto";
            this.button_editar.UseVisualStyleBackColor = true;
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(87, 12);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(93, 23);
            this.button_agregar.TabIndex = 13;
            this.button_agregar.Text = "Añadir contacto";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(5, 12);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_actualizar.TabIndex = 12;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 335);
            this.dataGridView1.TabIndex = 16;
            // 
            // button_guardar_en_archivo
            // 
            this.button_guardar_en_archivo.Location = new System.Drawing.Point(374, 12);
            this.button_guardar_en_archivo.Name = "button_guardar_en_archivo";
            this.button_guardar_en_archivo.Size = new System.Drawing.Size(120, 23);
            this.button_guardar_en_archivo.TabIndex = 17;
            this.button_guardar_en_archivo.Text = "Guardar en archivo";
            this.button_guardar_en_archivo.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 390);
            this.Controls.Add(this.button_guardar_en_archivo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.button_actualizar);
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_guardar_en_archivo;
    }
}

