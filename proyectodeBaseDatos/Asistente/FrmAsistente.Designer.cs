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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(898, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu Asistente ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(250, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 665);
            this.panel1.TabIndex = 14;
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbienvenida.Location = new System.Drawing.Point(300, 20);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(131, 29);
            this.labelbienvenida.TabIndex = 15;
            this.labelbienvenida.Text = "bienvenida";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.agregarMedicamentoToolStripMenuItem,
            this.modificarMedicamentoToolStripMenuItem,
            this.eliminarMedicamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(220, 870);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            this.medicamentosToolStripMenuItem.Click += new System.EventHandler(this.medicamentosToolStripMenuItem_Click);
            // 
            // agregarMedicamentoToolStripMenuItem
            // 
            this.agregarMedicamentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agregarMedicamentoToolStripMenuItem.Name = "agregarMedicamentoToolStripMenuItem";
            this.agregarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.agregarMedicamentoToolStripMenuItem.Text = "Agregar medicamento";
            this.agregarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.agregarMedicamentoToolStripMenuItem_Click);
            // 
            // modificarMedicamentoToolStripMenuItem
            // 
            this.modificarMedicamentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modificarMedicamentoToolStripMenuItem.Name = "modificarMedicamentoToolStripMenuItem";
            this.modificarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.modificarMedicamentoToolStripMenuItem.Text = "Modificar medicamento";
            this.modificarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.modificarMedicamentoToolStripMenuItem_Click);
            // 
            // eliminarMedicamentoToolStripMenuItem
            // 
            this.eliminarMedicamentoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eliminarMedicamentoToolStripMenuItem.Name = "eliminarMedicamentoToolStripMenuItem";
            this.eliminarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(213, 29);
            this.eliminarMedicamentoToolStripMenuItem.Text = "Eliminar medicamento";
            this.eliminarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.eliminarMedicamentoToolStripMenuItem_Click);
            // 
            // FrmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1734, 870);
            this.Controls.Add(this.labelbienvenida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAsistente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAsistente_Load);
            this.Shown += new System.EventHandler(this.label_shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMedicamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMedicamentoToolStripMenuItem;
    }
}