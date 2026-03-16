namespace SistemaPrestamos.Forms
{
    partial class FormClientes
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
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxcedula = new System.Windows.Forms.TextBox();
			this.textBoxmonto = new System.Windows.Forms.TextBox();
			this.buttonguardar = new System.Windows.Forms.Button();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.buttonborrar = new System.Windows.Forms.Button();
			this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(312, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clientes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cedula:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Monto:";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(108, 116);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(232, 22);
			this.textBoxNombre.TabIndex = 4;
			// 
			// textBoxcedula
			// 
			this.textBoxcedula.Location = new System.Drawing.Point(97, 164);
			this.textBoxcedula.Name = "textBoxcedula";
			this.textBoxcedula.Size = new System.Drawing.Size(232, 22);
			this.textBoxcedula.TabIndex = 5;
			// 
			// textBoxmonto
			// 
			this.textBoxmonto.Location = new System.Drawing.Point(97, 205);
			this.textBoxmonto.Name = "textBoxmonto";
			this.textBoxmonto.Size = new System.Drawing.Size(232, 22);
			this.textBoxmonto.TabIndex = 6;
			// 
			// buttonguardar
			// 
			this.buttonguardar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonguardar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonguardar.Location = new System.Drawing.Point(467, 116);
			this.buttonguardar.Name = "buttonguardar";
			this.buttonguardar.Size = new System.Drawing.Size(98, 40);
			this.buttonguardar.TabIndex = 7;
			this.buttonguardar.Text = "Guardar";
			this.buttonguardar.UseVisualStyleBackColor = true;
			this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBuscar.Location = new System.Drawing.Point(634, 116);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(98, 40);
			this.buttonBuscar.TabIndex = 8;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			// 
			// buttonborrar
			// 
			this.buttonborrar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonborrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonborrar.Location = new System.Drawing.Point(555, 187);
			this.buttonborrar.Name = "buttonborrar";
			this.buttonborrar.Size = new System.Drawing.Size(98, 40);
			this.buttonborrar.TabIndex = 9;
			this.buttonborrar.Text = "Borrar";
			this.buttonborrar.UseVisualStyleBackColor = true;
			// 
			// dataGridViewClientes
			// 
			this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClientes.Location = new System.Drawing.Point(79, 263);
			this.dataGridViewClientes.Name = "dataGridViewClientes";
			this.dataGridViewClientes.RowHeadersWidth = 51;
			this.dataGridViewClientes.RowTemplate.Height = 24;
			this.dataGridViewClientes.Size = new System.Drawing.Size(536, 175);
			this.dataGridViewClientes.TabIndex = 10;
			// 
			// FormClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridViewClientes);
			this.Controls.Add(this.buttonborrar);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.buttonguardar);
			this.Controls.Add(this.textBoxmonto);
			this.Controls.Add(this.textBoxcedula);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormClientes";
			this.Text = "FormReporte";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxcedula;
        private System.Windows.Forms.TextBox textBoxmonto;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}