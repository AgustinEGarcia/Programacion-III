
namespace CRUD_WindowsForms_ADO.NET___SQL_Server
{
    partial class AgregarContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label_telefono = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_mail = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(13, 27);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(63, 24);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(183, 20);
            this.textBox_nombre.TabIndex = 1;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(63, 50);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(183, 20);
            this.textBox_telefono.TabIndex = 3;
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(13, 53);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(49, 13);
            this.label_telefono.TabIndex = 2;
            this.label_telefono.Text = "Teléfono";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(63, 76);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(183, 20);
            this.textBox_mail.TabIndex = 5;
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(22, 79);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(26, 13);
            this.label_mail.TabIndex = 4;
            this.label_mail.Text = "Mail";
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(88, 113);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(75, 23);
            this.button_agregar.TabIndex = 6;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 167);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Name = "AgregarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Button button_agregar;
    }
}