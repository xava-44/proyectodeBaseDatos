namespace proyectodeBaseDatos
{
    partial class FrmRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxIDempleado = new System.Windows.Forms.TextBox();
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonRegresa = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No.Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo:";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domainUpDown1.Items.Add("Administrador");
            this.domainUpDown1.Items.Add("Encargado de farmacia");
            this.domainUpDown1.Items.Add("Doctor");
            this.domainUpDown1.Location = new System.Drawing.Point(28, 284);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(135, 20);
            this.domainUpDown1.TabIndex = 5;
            this.domainUpDown1.Text = "PUESTO";
            this.domainUpDown1.Wrap = true;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(133, 86);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(135, 20);
            this.textBoxname.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(133, 118);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(135, 20);
            this.textBoxApellido.TabIndex = 7;
            // 
            // textBoxIDempleado
            // 
            this.textBoxIDempleado.Location = new System.Drawing.Point(133, 151);
            this.textBoxIDempleado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIDempleado.Name = "textBoxIDempleado";
            this.textBoxIDempleado.Size = new System.Drawing.Size(135, 20);
            this.textBoxIDempleado.TabIndex = 8;
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Location = new System.Drawing.Point(133, 184);
            this.textBoxSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(135, 20);
            this.textBoxSueldo.TabIndex = 9;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(133, 216);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(135, 20);
            this.textBoxTelefono.TabIndex = 10;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(28, 333);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(77, 31);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonRegresa
            // 
            this.buttonRegresa.Location = new System.Drawing.Point(184, 333);
            this.buttonRegresa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegresa.Name = "buttonRegresa";
            this.buttonRegresa.Size = new System.Drawing.Size(84, 31);
            this.buttonRegresa.TabIndex = 12;
            this.buttonRegresa.Text = "Regresar";
            this.buttonRegresa.UseVisualStyleBackColor = true;
            this.buttonRegresa.Click += new System.EventHandler(this.buttonRegresa_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(133, 248);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(135, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registro";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRegresa);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxSueldo);
            this.Controls.Add(this.textBoxIDempleado);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxIDempleado;
        private System.Windows.Forms.TextBox textBoxSueldo;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonRegresa;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}