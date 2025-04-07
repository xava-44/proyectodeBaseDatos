namespace proyectodeBaseDatos
{
    partial class FrmAsistente
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
            this.btnVerListaEmpleados = new System.Windows.Forms.Button();
            this.btnVerListaPacientes = new System.Windows.Forms.Button();
            this.btnConsultarMedicamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Panel Asistente";
            // 
            // btnVerListaEmpleados
            // 
            this.btnVerListaEmpleados.Location = new System.Drawing.Point(41, 211);
            this.btnVerListaEmpleados.Name = "btnVerListaEmpleados";
            this.btnVerListaEmpleados.Size = new System.Drawing.Size(200, 30);
            this.btnVerListaEmpleados.TabIndex = 8;
            this.btnVerListaEmpleados.Text = "Ver Lista de Empleados";
            this.btnVerListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnVerListaPacientes
            // 
            this.btnVerListaPacientes.Location = new System.Drawing.Point(41, 161);
            this.btnVerListaPacientes.Name = "btnVerListaPacientes";
            this.btnVerListaPacientes.Size = new System.Drawing.Size(200, 30);
            this.btnVerListaPacientes.TabIndex = 7;
            this.btnVerListaPacientes.Text = "Ver Lista de Pacientes";
            this.btnVerListaPacientes.UseVisualStyleBackColor = true;
            // 
            // btnConsultarMedicamento
            // 
            this.btnConsultarMedicamento.Location = new System.Drawing.Point(41, 111);
            this.btnConsultarMedicamento.Name = "btnConsultarMedicamento";
            this.btnConsultarMedicamento.Size = new System.Drawing.Size(200, 30);
            this.btnConsultarMedicamento.TabIndex = 6;
            this.btnConsultarMedicamento.Text = "Consultar Medicamento";
            this.btnConsultarMedicamento.UseVisualStyleBackColor = true;
            // 
            // FrmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerListaEmpleados);
            this.Controls.Add(this.btnVerListaPacientes);
            this.Controls.Add(this.btnConsultarMedicamento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAsistente";
            this.Text = "FormMenuAsistente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerListaEmpleados;
        private System.Windows.Forms.Button btnVerListaPacientes;
        private System.Windows.Forms.Button btnConsultarMedicamento;
    }
}