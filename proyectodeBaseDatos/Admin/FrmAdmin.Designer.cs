namespace proyectodeBaseDatos
{
    partial class FrmAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnConsultarMedicamento;
        private System.Windows.Forms.Button btnVerListaPacientes;
        private System.Windows.Forms.Button btnVerListaEmpleados;

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
            this.btnConsultarMedicamento = new System.Windows.Forms.Button();
            this.btnVerListaPacientes = new System.Windows.Forms.Button();
            this.btnVerListaEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarMedicamento
            // 
            this.btnConsultarMedicamento.Location = new System.Drawing.Point(50, 92);
            this.btnConsultarMedicamento.Name = "btnConsultarMedicamento";
            this.btnConsultarMedicamento.Size = new System.Drawing.Size(200, 30);
            this.btnConsultarMedicamento.TabIndex = 0;
            this.btnConsultarMedicamento.Text = "Consultar Medicamento";
            this.btnConsultarMedicamento.UseVisualStyleBackColor = true;
            this.btnConsultarMedicamento.Click += new System.EventHandler(this.btnConsultarMedicamento_Click);
            // 
            // btnVerListaPacientes
            // 
            this.btnVerListaPacientes.Location = new System.Drawing.Point(50, 142);
            this.btnVerListaPacientes.Name = "btnVerListaPacientes";
            this.btnVerListaPacientes.Size = new System.Drawing.Size(200, 30);
            this.btnVerListaPacientes.TabIndex = 3;
            this.btnVerListaPacientes.Text = "Ver Lista de Pacientes";
            this.btnVerListaPacientes.UseVisualStyleBackColor = true;
            // 
            // btnVerListaEmpleados
            // 
            this.btnVerListaEmpleados.Location = new System.Drawing.Point(50, 192);
            this.btnVerListaEmpleados.Name = "btnVerListaEmpleados";
            this.btnVerListaEmpleados.Size = new System.Drawing.Size(200, 30);
            this.btnVerListaEmpleados.TabIndex = 4;
            this.btnVerListaEmpleados.Text = "Ver Lista de Empleados";
            this.btnVerListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Panel Administrador";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ver Registro de Cambios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerListaEmpleados);
            this.Controls.Add(this.btnVerListaPacientes);
            this.Controls.Add(this.btnConsultarMedicamento);
            this.Name = "FrmAdmin";
            this.Text = "Administrador de Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}