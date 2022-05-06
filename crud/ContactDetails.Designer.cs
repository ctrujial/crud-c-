namespace crud
{
    partial class ContactDetails
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
            this.btonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contacto1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btonCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelContacto = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btonGuardar
            // 
            this.btonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonGuardar.Location = new System.Drawing.Point(158, 262);
            this.btonGuardar.Name = "btonGuardar";
            this.btonGuardar.Size = new System.Drawing.Size(84, 23);
            this.btonGuardar.TabIndex = 0;
            this.btonGuardar.Text = "Guardar";
            this.btonGuardar.UseVisualStyleBackColor = true;
            this.btonGuardar.Click += new System.EventHandler(this.btonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // contacto1
            // 
            this.contacto1.AutoSize = true;
            this.contacto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto1.Location = new System.Drawing.Point(43, 141);
            this.contacto1.Name = "contacto1";
            this.contacto1.Size = new System.Drawing.Size(135, 18);
            this.contacto1.TabIndex = 3;
            this.contacto1.Text = "Celular Contacto";
            this.contacto1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btonCancelar
            // 
            this.btonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonCancelar.Location = new System.Drawing.Point(279, 262);
            this.btonCancelar.Name = "btonCancelar";
            this.btonCancelar.Size = new System.Drawing.Size(83, 23);
            this.btonCancelar.TabIndex = 5;
            this.btonCancelar.Text = "Cancelar";
            this.btonCancelar.UseVisualStyleBackColor = true;
            this.btonCancelar.Click += new System.EventHandler(this.btonCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(192, 192);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(269, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtCelContacto
            // 
            this.txtCelContacto.Location = new System.Drawing.Point(190, 141);
            this.txtCelContacto.Name = "txtCelContacto";
            this.txtCelContacto.Size = new System.Drawing.Size(269, 20);
            this.txtCelContacto.TabIndex = 8;
            this.txtCelContacto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(190, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(271, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCelContacto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btonCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contacto1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonGuardar);
            this.Name = "ContactDetails";
            this.Text = "ContactDetails";
            this.Load += new System.EventHandler(this.ContactDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label contacto1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btonCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelContacto;
        private System.Windows.Forms.TextBox txtApellido;
    }
}