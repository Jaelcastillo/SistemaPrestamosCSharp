namespace SistemaPrestamos.Forms
{
    partial class FormPrestamo
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
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxClientes = new System.Windows.Forms.TextBox();
			this.textBoxMonto = new System.Windows.Forms.TextBox();
			this.textBoxInteres = new System.Windows.Forms.TextBox();
			this.textBoxFecha = new System.Windows.Forms.TextBox();
			this.botonguardar = new System.Windows.Forms.Button();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.buttonBorrar = new System.Windows.Forms.Button();
			this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
			this.Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(310, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Prestamos";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Clientes:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(39, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Monto:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Interes:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(40, 221);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Fecha:";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBoxClientes
			// 
			this.textBoxClientes.Location = new System.Drawing.Point(129, 111);
			this.textBoxClientes.Name = "textBoxClientes";
			this.textBoxClientes.Size = new System.Drawing.Size(187, 22);
			this.textBoxClientes.TabIndex = 5;
			// 
			// textBoxMonto
			// 
			this.textBoxMonto.Location = new System.Drawing.Point(129, 141);
			this.textBoxMonto.Name = "textBoxMonto";
			this.textBoxMonto.Size = new System.Drawing.Size(187, 22);
			this.textBoxMonto.TabIndex = 6;
			// 
			// textBoxInteres
			// 
			this.textBoxInteres.Location = new System.Drawing.Point(129, 181);
			this.textBoxInteres.Name = "textBoxInteres";
			this.textBoxInteres.Size = new System.Drawing.Size(187, 22);
			this.textBoxInteres.TabIndex = 7;
			// 
			// textBoxFecha
			// 
			this.textBoxFecha.Location = new System.Drawing.Point(129, 221);
			this.textBoxFecha.Name = "textBoxFecha";
			this.textBoxFecha.Size = new System.Drawing.Size(187, 22);
			this.textBoxFecha.TabIndex = 8;
			// 
			// botonguardar
			// 
			this.botonguardar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonguardar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.botonguardar.Location = new System.Drawing.Point(40, 311);
			this.botonguardar.Name = "botonguardar";
			this.botonguardar.Size = new System.Drawing.Size(89, 40);
			this.botonguardar.TabIndex = 9;
			this.botonguardar.Text = "Guardar";
			this.botonguardar.UseVisualStyleBackColor = true;
			this.botonguardar.Click += new System.EventHandler(this.botonguardar_Click);
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBuscar.Location = new System.Drawing.Point(153, 311);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(104, 40);
			this.buttonBuscar.TabIndex = 10;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
			// 
			// buttonBorrar
			// 
			this.buttonBorrar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBorrar.Location = new System.Drawing.Point(284, 311);
			this.buttonBorrar.Name = "buttonBorrar";
			this.buttonBorrar.Size = new System.Drawing.Size(98, 40);
			this.buttonBorrar.TabIndex = 11;
			this.buttonBorrar.Text = "Borrar";
			this.buttonBorrar.UseVisualStyleBackColor = true;
			this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
			// 
			// dataGridViewPrestamos
			// 
			this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clientes,
            this.Monto,
            this.Interes,
            this.Fecha});
			this.dataGridViewPrestamos.Location = new System.Drawing.Point(417, 100);
			this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
			this.dataGridViewPrestamos.RowHeadersWidth = 51;
			this.dataGridViewPrestamos.RowTemplate.Height = 24;
			this.dataGridViewPrestamos.Size = new System.Drawing.Size(572, 422);
			this.dataGridViewPrestamos.TabIndex = 12;
			// 
			// Clientes
			// 
			this.Clientes.HeaderText = "Clientes";
			this.Clientes.MinimumWidth = 6;
			this.Clientes.Name = "Clientes";
			this.Clientes.Width = 125;
			// 
			// Monto
			// 
			this.Monto.HeaderText = "Monto";
			this.Monto.MinimumWidth = 6;
			this.Monto.Name = "Monto";
			this.Monto.Width = 125;
			// 
			// Interes
			// 
			this.Interes.HeaderText = "Interes";
			this.Interes.MinimumWidth = 6;
			this.Interes.Name = "Interes";
			this.Interes.Width = 125;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.MinimumWidth = 6;
			this.Fecha.Name = "Fecha";
			this.Fecha.Width = 125;
			// 
			// FormPrestamo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 534);
			this.Controls.Add(this.dataGridViewPrestamos);
			this.Controls.Add(this.buttonBorrar);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.botonguardar);
			this.Controls.Add(this.textBoxFecha);
			this.Controls.Add(this.textBoxInteres);
			this.Controls.Add(this.textBoxMonto);
			this.Controls.Add(this.textBoxClientes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormPrestamo";
			this.Text = "FormPrestamo";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClientes;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxInteres;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Button botonguardar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}