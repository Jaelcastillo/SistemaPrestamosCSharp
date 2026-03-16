namespace SistemaPrestamos
{
    partial class FormMenu
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.registrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultalClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.solicitarPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.amortizarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1118, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// prestamosToolStripMenuItem
			// 
			this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarPrestamosToolStripMenuItem,
            this.amortizarPrestamoToolStripMenuItem});
			this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
			this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
			this.prestamosToolStripMenuItem.Text = "Prestamos";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClientesToolStripMenuItem,
            this.consultalClientesToolStripMenuItem});
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// registrarClientesToolStripMenuItem
			// 
			this.registrarClientesToolStripMenuItem.Name = "registrarClientesToolStripMenuItem";
			this.registrarClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.registrarClientesToolStripMenuItem.Text = "Registrar Clientes";
			this.registrarClientesToolStripMenuItem.Click += new System.EventHandler(this.registrarClientesToolStripMenuItem_Click);
			// 
			// consultalClientesToolStripMenuItem
			// 
			this.consultalClientesToolStripMenuItem.Name = "consultalClientesToolStripMenuItem";
			this.consultalClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.consultalClientesToolStripMenuItem.Text = "Consultal clientes";
			// 
			// solicitarPrestamosToolStripMenuItem
			// 
			this.solicitarPrestamosToolStripMenuItem.Name = "solicitarPrestamosToolStripMenuItem";
			this.solicitarPrestamosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.solicitarPrestamosToolStripMenuItem.Text = "Solicitar Prestamos";
			// 
			// amortizarPrestamoToolStripMenuItem
			// 
			this.amortizarPrestamoToolStripMenuItem.Name = "amortizarPrestamoToolStripMenuItem";
			this.amortizarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.amortizarPrestamoToolStripMenuItem.Text = "Amortizar Prestamo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 522);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMenu";
			this.Text = "Sistema de Préstamos";
			this.Load += new System.EventHandler(this.FormMenu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amortizarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultalClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

