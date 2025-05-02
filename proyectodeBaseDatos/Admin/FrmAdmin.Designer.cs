namespace proyectodeBaseDatos
{
    partial class FrmAdmin
    {
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
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMedicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 5;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmin.Location = new System.Drawing.Point(274, 68);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(1146, 659);
            this.panelAdmin.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEmpleadosToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem,
            this.listaDeMedicamentosToolStripMenuItem,
            this.modificarMedicamentoToolStripMenuItem,
            this.crearReporteToolStripMenuItem,
            this.historialDeReportesToolStripMenuItem,
            this.listaDePacientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 764);
            this.menuStrip1.TabIndex = 9;
            // 
            // listaDeEmpleadosToolStripMenuItem
            // 
            this.listaDeEmpleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listaDeEmpleadosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeEmpleadosToolStripMenuItem.Name = "listaDeEmpleadosToolStripMenuItem";
            this.listaDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.listaDeEmpleadosToolStripMenuItem.Text = "Lista de Empleados";
            this.listaDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpleadosToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarEmpleadoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // listaDeMedicamentosToolStripMenuItem
            // 
            this.listaDeMedicamentosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listaDeMedicamentosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDeMedicamentosToolStripMenuItem.Name = "listaDeMedicamentosToolStripMenuItem";
            this.listaDeMedicamentosToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.listaDeMedicamentosToolStripMenuItem.Text = "Lista de medicamentos";
            // 
            // modificarMedicamentoToolStripMenuItem
            // 
            this.modificarMedicamentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarMedicamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarMedicamentoToolStripMenuItem.Name = "modificarMedicamentoToolStripMenuItem";
            this.modificarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.modificarMedicamentoToolStripMenuItem.Text = "Modificar medicamento";
            // 
            // crearReporteToolStripMenuItem
            // 
            this.crearReporteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.crearReporteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearReporteToolStripMenuItem.Name = "crearReporteToolStripMenuItem";
            this.crearReporteToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.crearReporteToolStripMenuItem.Text = "Crear reporte";
            // 
            // historialDeReportesToolStripMenuItem
            // 
            this.historialDeReportesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Menu;
            this.historialDeReportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialDeReportesToolStripMenuItem.Name = "historialDeReportesToolStripMenuItem";
            this.historialDeReportesToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.historialDeReportesToolStripMenuItem.Text = "Historial de reportes";
            // 
            // listaDePacientesToolStripMenuItem
            // 
            this.listaDePacientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listaDePacientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDePacientesToolStripMenuItem.Name = "listaDePacientesToolStripMenuItem";
            this.listaDePacientesToolStripMenuItem.Size = new System.Drawing.Size(233, 32);
            this.listaDePacientesToolStripMenuItem.Text = "Lista de pacientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menu Administrador";
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbienvenida.Location = new System.Drawing.Point(393, 13);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(143, 29);
            this.labelbienvenida.TabIndex = 11;
            this.labelbienvenida.Text = "Bienvenida";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1709, 764);
            this.Controls.Add(this.labelbienvenida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAdmin";
            this.Text = "Administrador de Hospital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.label_shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMedicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePacientesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelbienvenida;
    }
}