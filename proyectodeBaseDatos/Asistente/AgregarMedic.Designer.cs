namespace proyectodeBaseDatos.Asistente
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
            this.Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelnum_medic = new System.Windows.Forms.Label();
            this.labelprecio = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxNUM_medic = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.dateTimeCaducidad = new System.Windows.Forms.DateTimePicker();
            this.labelcaduci = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(409, 535);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(125, 51);
            this.Guardar.TabIndex = 1;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de nuevo medicamento";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(272, 162);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(76, 22);
            this.labelnombre.TabIndex = 3;
            this.labelnombre.Text = "nombre";
            this.labelnombre.UseWaitCursor = true;
            // 
            // labelnum_medic
            // 
            this.labelnum_medic.AutoSize = true;
            this.labelnum_medic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnum_medic.Location = new System.Drawing.Point(176, 232);
            this.labelnum_medic.Name = "labelnum_medic";
            this.labelnum_medic.Size = new System.Drawing.Size(175, 22);
            this.labelnum_medic.TabIndex = 4;
            this.labelnum_medic.Text = "num_medicamento";
            // 
            // labelprecio
            // 
            this.labelprecio.AutoSize = true;
            this.labelprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprecio.Location = new System.Drawing.Point(281, 288);
            this.labelprecio.Name = "labelprecio";
            this.labelprecio.Size = new System.Drawing.Size(67, 22);
            this.labelprecio.TabIndex = 5;
            this.labelprecio.Text = "Precio";
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(262, 358);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(86, 22);
            this.cantidad.TabIndex = 6;
            this.cantidad.Text = "cantidad";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(389, 161);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 26);
            this.textBoxnombre.TabIndex = 7;
            // 
            // textBoxNUM_medic
            // 
            this.textBoxNUM_medic.Location = new System.Drawing.Point(389, 228);
            this.textBoxNUM_medic.Name = "textBoxNUM_medic";
            this.textBoxNUM_medic.Size = new System.Drawing.Size(100, 26);
            this.textBoxNUM_medic.TabIndex = 8;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(389, 284);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 26);
            this.textBoxPrecio.TabIndex = 9;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(389, 358);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 26);
            this.textBoxCantidad.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descripcion";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(389, 431);
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(100, 26);
            this.textBoxDescrip.TabIndex = 12;
            // 
            // dateTimeCaducidad
            // 
            this.dateTimeCaducidad.Location = new System.Drawing.Point(389, 484);
            this.dateTimeCaducidad.Name = "dateTimeCaducidad";
            this.dateTimeCaducidad.Size = new System.Drawing.Size(366, 26);
            this.dateTimeCaducidad.TabIndex = 13;
            // 
            // labelcaduci
            // 
            this.labelcaduci.AutoSize = true;
            this.labelcaduci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaduci.Location = new System.Drawing.Point(167, 484);
            this.labelcaduci.Name = "labelcaduci";
            this.labelcaduci.Size = new System.Drawing.Size(184, 22);
            this.labelcaduci.TabIndex = 14;
            this.labelcaduci.Text = "fecha de caducidad";
            this.labelcaduci.Click += new System.EventHandler(this.labelcaduci_Click);
            // 
            // AgregarMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.labelcaduci);
            this.Controls.Add(this.dateTimeCaducidad);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxNUM_medic);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.labelprecio);
            this.Controls.Add(this.labelnum_medic);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Name = "AgregarMedic";
            this.Size = new System.Drawing.Size(1032, 836);
            this.Load += new System.EventHandler(this.AgregarMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelnum_medic;
        private System.Windows.Forms.Label labelprecio;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxNUM_medic;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.DateTimePicker dateTimeCaducidad;
        private System.Windows.Forms.Label labelcaduci;
    }
}
