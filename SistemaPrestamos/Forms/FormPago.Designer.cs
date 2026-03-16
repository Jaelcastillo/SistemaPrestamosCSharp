namespace SistemaPrestamos.Forms
{
    partial class FormPago
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
			this.textBoxclientes = new System.Windows.Forms.TextBox();
			this.textBoxpagado = new System.Windows.Forms.TextBox();
			this.textBoxfecha = new System.Windows.Forms.TextBox();
			this.textBoxmetodo = new System.Windows.Forms.TextBox();
			this.buttonguardar = new System.Windows.Forms.Button();
			this.buttonborrar = new System.Windows.Forms.Button();
			this.dataGridViewpago = new System.Windows.Forms.DataGridView();
			this.Clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonbuscar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewpago)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(285, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pago Del Cliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Clientes:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Monto Pagado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(61, 241);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Metodo De Pago:";
			// 
			// textBoxclientes
			// 
			this.textBoxclientes.Location = new System.Drawing.Point(142, 130);
			this.textBoxclientes.Name = "textBoxclientes";
			this.textBoxclientes.Size = new System.Drawing.Size(191, 22);
			this.textBoxclientes.TabIndex = 5;
			// 
			// textBoxpagado
			// 
			this.textBoxpagado.Location = new System.Drawing.Point(167, 162);
			this.textBoxpagado.Name = "textBoxpagado";
			this.textBoxpagado.Size = new System.Drawing.Size(162, 22);
			this.textBoxpagado.TabIndex = 6;
			// 
			// textBoxfecha
			// 
			this.textBoxfecha.Location = new System.Drawing.Point(167, 197);
			this.textBoxfecha.Name = "textBoxfecha";
			this.textBoxfecha.Size = new System.Drawing.Size(160, 22);
			this.textBoxfecha.TabIndex = 7;
			// 
			// textBoxmetodo
			// 
			this.textBoxmetodo.Location = new System.Drawing.Point(179, 241);
			this.textBoxmetodo.Name = "textBoxmetodo";
			this.textBoxmetodo.Size = new System.Drawing.Size(154, 22);
			this.textBoxmetodo.TabIndex = 8;
			// 
			// buttonguardar
			// 
			this.buttonguardar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonguardar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonguardar.Location = new System.Drawing.Point(475, 132);
			this.buttonguardar.Name = "buttonguardar";
			this.buttonguardar.Size = new System.Drawing.Size(85, 35);
			this.buttonguardar.TabIndex = 9;
			this.buttonguardar.Text = "Guardar";
			this.buttonguardar.UseVisualStyleBackColor = true;
			this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
			// 
			// buttonborrar
			// 
			this.buttonborrar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonborrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonborrar.Location = new System.Drawing.Point(574, 202);
			this.buttonborrar.Name = "buttonborrar";
			this.buttonborrar.Size = new System.Drawing.Size(90, 37);
			this.buttonborrar.TabIndex = 10;
			this.buttonborrar.Text = "Borrar";
			this.buttonborrar.UseVisualStyleBackColor = true;
			this.buttonborrar.Click += new System.EventHandler(this.buttonborrar_Click);
			// 
			// dataGridViewpago
			// 
			this.dataGridViewpago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewpago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clientes,
            this.Pagado,
            this.Fecha,
            this.pago});
			this.dataGridViewpago.Location = new System.Drawing.Point(37, 321);
			this.dataGridViewpago.Name = "dataGridViewpago";
			this.dataGridViewpago.RowHeadersWidth = 51;
			this.dataGridViewpago.RowTemplate.Height = 24;
			this.dataGridViewpago.Size = new System.Drawing.Size(558, 231);
			this.dataGridViewpago.TabIndex = 12;
			// 
			// Clientes
			// 
			this.Clientes.HeaderText = "Clientes";
			this.Clientes.MinimumWidth = 6;
			this.Clientes.Name = "Clientes";
			this.Clientes.Width = 125;
			// 
			// Pagado
			// 
			this.Pagado.HeaderText = "Pagado";
			this.Pagado.MinimumWidth = 6;
			this.Pagado.Name = "Pagado";
			this.Pagado.Width = 125;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha";
			this.Fecha.MinimumWidth = 6;
			this.Fecha.Name = "Fecha";
			this.Fecha.Width = 125;
			// 
			// pago
			// 
			this.pago.HeaderText = "pago";
			this.pago.MinimumWidth = 6;
			this.pago.Name = "pago";
			this.pago.Width = 125;
			// 
			// buttonbuscar
			// 
			this.buttonbuscar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonbuscar.Location = new System.Drawing.Point(666, 132);
			this.buttonbuscar.Name = "buttonbuscar";
			this.buttonbuscar.Size = new System.Drawing.Size(89, 35);
			this.buttonbuscar.TabIndex = 11;
			this.buttonbuscar.Text = "Buscar";
			this.buttonbuscar.UseVisualStyleBackColor = true;
			this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
			// 
			// FormPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 564);
			this.Controls.Add(this.dataGridViewpago);
			this.Controls.Add(this.buttonbuscar);
			this.Controls.Add(this.buttonborrar);
			this.Controls.Add(this.buttonguardar);
			this.Controls.Add(this.textBoxmetodo);
			this.Controls.Add(this.textBoxfecha);
			this.Controls.Add(this.textBoxpagado);
			this.Controls.Add(this.textBoxclientes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormPago";
			this.Text = "FormPago";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewpago)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxclientes;
        private System.Windows.Forms.TextBox textBoxpagado;
        private System.Windows.Forms.TextBox textBoxfecha;
        private System.Windows.Forms.TextBox textBoxmetodo;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttonborrar;
        private System.Windows.Forms.DataGridView dataGridViewpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago;
        private System.Windows.Forms.Button buttonbuscar;
    }
}