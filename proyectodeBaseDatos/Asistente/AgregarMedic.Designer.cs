﻿namespace proyectodeBaseDatos.Asistente
{
    partial class AgregarMedic
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tablamedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablamedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablamedicamentos
            // 
            this.tablamedicamentos.AllowUserToOrderColumns = true;
            this.tablamedicamentos.CausesValidation = false;
            this.tablamedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablamedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablamedicamentos.Location = new System.Drawing.Point(0, 0);
            this.tablamedicamentos.Name = "tablamedicamentos";
            this.tablamedicamentos.RowHeadersWidth = 62;
            this.tablamedicamentos.RowTemplate.Height = 28;
            this.tablamedicamentos.Size = new System.Drawing.Size(1488, 652);
            this.tablamedicamentos.TabIndex = 0;
            // 
            // AgregarMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.tablamedicamentos);
            this.Name = "AgregarMedic";
            this.Size = new System.Drawing.Size(1488, 652);
            this.Load += new System.EventHandler(this.AgregarMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablamedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablamedicamentos;
    }
}
