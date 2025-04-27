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
            this.agregar = new System.Windows.Forms.Button();
            this.listamedicamento = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbienvenida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gestion de medicamentos ";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.SkyBlue;
            this.agregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(403, 145);
            this.agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(236, 46);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "Agregar medicamento";
            this.agregar.UseVisualStyleBackColor = false;
            // 
            // listamedicamento
            // 
            this.listamedicamento.BackColor = System.Drawing.Color.SkyBlue;
            this.listamedicamento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listamedicamento.Location = new System.Drawing.Point(97, 145);
            this.listamedicamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listamedicamento.Name = "listamedicamento";
            this.listamedicamento.Size = new System.Drawing.Size(229, 46);
            this.listamedicamento.TabIndex = 7;
            this.listamedicamento.Text = " Medicamentos ";
            this.listamedicamento.UseVisualStyleBackColor = false;
            this.listamedicamento.Click += new System.EventHandler(this.listamedicamento_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.eliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(983, 145);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(225, 45);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar medicamento";
            this.eliminar.UseVisualStyleBackColor = false;
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.Color.SkyBlue;
            this.modificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.Location = new System.Drawing.Point(692, 144);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(242, 46);
            this.modificar.TabIndex = 11;
            this.modificar.Text = "Modificar medicamento";
            this.modificar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(86, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 501);
            this.panel1.TabIndex = 14;
            // 
            // labelbienvenida
            // 
            this.labelbienvenida.AutoSize = true;
            this.labelbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbienvenida.Location = new System.Drawing.Point(127, 29);
            this.labelbienvenida.Name = "labelbienvenida";
            this.labelbienvenida.Size = new System.Drawing.Size(141, 29);
            this.labelbienvenida.TabIndex = 15;
            this.labelbienvenida.Text = "bienvenida";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1247, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelbienvenida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.listamedicamento);
            this.Name = "FrmAsistente";
            this.Load += new System.EventHandler(this.FrmAsistente_Load);
            this.Shown += new System.EventHandler(this.label_shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button listamedicamento;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbienvenida;
        private System.Windows.Forms.Button button1;
    }
}