namespace proyectodeBaseDatos.Admin
{
    partial class EliminarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttEmliminar = new System.Windows.Forms.Button();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id del empleado";
            // 
            // buttEmliminar
            // 
            this.buttEmliminar.Location = new System.Drawing.Point(232, 267);
            this.buttEmliminar.Name = "buttEmliminar";
            this.buttEmliminar.Size = new System.Drawing.Size(118, 52);
            this.buttEmliminar.TabIndex = 2;
            this.buttEmliminar.Text = "Eliminar";
            this.buttEmliminar.UseVisualStyleBackColor = true;
            this.buttEmliminar.Click += new System.EventHandler(this.buttEmliminar_Click);
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(292, 154);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(100, 26);
            this.textBoxEliminar.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxEliminar);
            this.Controls.Add(this.buttEmliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EliminarEmpleado";
            this.Size = new System.Drawing.Size(801, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttEmliminar;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Button button2;
    }
}
