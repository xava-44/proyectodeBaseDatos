namespace proyectodeBaseDatos.Asistente
{
    partial class listamedicamentos
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
            this.dataGridView_medic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_medic
            // 
            this.dataGridView_medic.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView_medic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_medic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_medic.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_medic.Name = "dataGridView_medic";
            this.dataGridView_medic.RowHeadersWidth = 62;
            this.dataGridView_medic.RowTemplate.Height = 28;
            this.dataGridView_medic.Size = new System.Drawing.Size(778, 487);
            this.dataGridView_medic.TabIndex = 0;
            // 
            // listamedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_medic);
            this.Name = "listamedicamentos";
            this.Size = new System.Drawing.Size(778, 487);
            this.Load += new System.EventHandler(this.listamedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_medic;
    }
}
