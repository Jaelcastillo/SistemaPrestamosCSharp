namespace SistemaPrestamos.Forms
{
    partial class FormReportes
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
			this.textBoxtipo = new System.Windows.Forms.TextBox();
			this.textBoxinicio = new System.Windows.Forms.TextBox();
			this.textBoxfin = new System.Windows.Forms.TextBox();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.buttonBorrar = new System.Windows.Forms.Button();
			this.dataGridViewreportes = new System.Windows.Forms.DataGridView();
			this.reportes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewreportes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(322, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reportes";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tipos De Reportes:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(58, 167);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha De Inicio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(58, 206);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha De Fin:";
			// 
			// textBoxtipo
			// 
			this.textBoxtipo.Location = new System.Drawing.Point(194, 120);
			this.textBoxtipo.Name = "textBoxtipo";
			this.textBoxtipo.Size = new System.Drawing.Size(147, 22);
			this.textBoxtipo.TabIndex = 4;
			// 
			// textBoxinicio
			// 
			this.textBoxinicio.Location = new System.Drawing.Point(173, 162);
			this.textBoxinicio.Name = "textBoxinicio";
			this.textBoxinicio.Size = new System.Drawing.Size(147, 22);
			this.textBoxinicio.TabIndex = 5;
			// 
			// textBoxfin
			// 
			this.textBoxfin.Location = new System.Drawing.Point(158, 204);
			this.textBoxfin.Name = "textBoxfin";
			this.textBoxfin.Size = new System.Drawing.Size(147, 22);
			this.textBoxfin.TabIndex = 6;
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBuscar.Location = new System.Drawing.Point(596, 157);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(78, 39);
			this.buttonBuscar.TabIndex = 7;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
			// 
			// buttonBorrar
			// 
			this.buttonBorrar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonBorrar.Location = new System.Drawing.Point(716, 158);
			this.buttonBorrar.Name = "buttonBorrar";
			this.buttonBorrar.Size = new System.Drawing.Size(76, 37);
			this.buttonBorrar.TabIndex = 8;
			this.buttonBorrar.Text = "Borrar";
			this.buttonBorrar.UseVisualStyleBackColor = true;
			this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
			// 
			// dataGridViewreportes
			// 
			this.dataGridViewreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewreportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportes,
            this.inicio,
            this.fin});
			this.dataGridViewreportes.Location = new System.Drawing.Point(101, 255);
			this.dataGridViewreportes.Name = "dataGridViewreportes";
			this.dataGridViewreportes.RowHeadersWidth = 51;
			this.dataGridViewreportes.RowTemplate.Height = 24;
			this.dataGridViewreportes.Size = new System.Drawing.Size(460, 257);
			this.dataGridViewreportes.TabIndex = 9;
			// 
			// reportes
			// 
			this.reportes.HeaderText = "reportes";
			this.reportes.MinimumWidth = 6;
			this.reportes.Name = "reportes";
			this.reportes.Width = 125;
			// 
			// inicio
			// 
			this.inicio.HeaderText = "inicio";
			this.inicio.MinimumWidth = 6;
			this.inicio.Name = "inicio";
			this.inicio.Width = 125;
			// 
			// fin
			// 
			this.fin.HeaderText = "fin";
			this.fin.MinimumWidth = 6;
			this.fin.Name = "fin";
			this.fin.Width = 125;
			// 
			// FormReportes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 524);
			this.Controls.Add(this.dataGridViewreportes);
			this.Controls.Add(this.buttonBorrar);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.textBoxfin);
			this.Controls.Add(this.textBoxinicio);
			this.Controls.Add(this.textBoxtipo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormReportes";
			this.Text = "FormReportes";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewreportes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxtipo;
        private System.Windows.Forms.TextBox textBoxinicio;
        private System.Windows.Forms.TextBox textBoxfin;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dataGridViewreportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportes;
        private System.Windows.Forms.DataGridViewTextBoxColumn inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin;
    }
}