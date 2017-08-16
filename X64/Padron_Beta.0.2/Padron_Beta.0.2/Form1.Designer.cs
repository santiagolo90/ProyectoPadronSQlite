namespace Padron_Beta._0._2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alicuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVigente = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.lblGuion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar Local";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(13, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(446, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // rtxt
            // 
            this.rtxt.BackColor = System.Drawing.Color.DarkGray;
            this.rtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtxt.Location = new System.Drawing.Point(12, 83);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(447, 81);
            this.rtxt.TabIndex = 2;
            this.rtxt.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(359, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(369, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(90, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Carga Local DB";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.CUIT,
            this.Alicuota,
            this.NroRetencion});
            this.dgv.Location = new System.Drawing.Point(13, 170);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(446, 171);
            this.dgv.TabIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 101;
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            this.CUIT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CUIT.Width = 101;
            // 
            // Alicuota
            // 
            this.Alicuota.HeaderText = "Alicuota";
            this.Alicuota.Name = "Alicuota";
            this.Alicuota.ReadOnly = true;
            this.Alicuota.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NroRetencion
            // 
            this.NroRetencion.HeaderText = "NroRetencion";
            this.NroRetencion.Name = "NroRetencion";
            this.NroRetencion.ReadOnly = true;
            this.NroRetencion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NroRetencion.Width = 101;
            // 
            // lblVigente
            // 
            this.lblVigente.AutoSize = true;
            this.lblVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVigente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVigente.Location = new System.Drawing.Point(10, 360);
            this.lblVigente.Name = "lblVigente";
            this.lblVigente.Size = new System.Drawing.Size(91, 13);
            this.lblVigente.TabIndex = 6;
            this.lblVigente.Text = "Vigente Hasta:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFechaHasta.Location = new System.Drawing.Point(107, 360);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(19, 13);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "\"\"";
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(12, 25);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar2.TabIndex = 8;
            this.btnBuscar2.Text = "Buscar en Base";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // lblGuion
            // 
            this.lblGuion.AutoSize = true;
            this.lblGuion.BackColor = System.Drawing.SystemColors.Window;
            this.lblGuion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuion.Location = new System.Drawing.Point(366, 59);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(91, 13);
            this.lblGuion.TabIndex = 9;
            this.lblGuion.Text = "CUIT sin guion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirBaseDeDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirBaseDeDatosToolStripMenuItem
            // 
            this.abrirBaseDeDatosToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.abrirBaseDeDatosToolStripMenuItem.Name = "abrirBaseDeDatosToolStripMenuItem";
            this.abrirBaseDeDatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.abrirBaseDeDatosToolStripMenuItem.Text = "Abrir Base de Datos";
            this.abrirBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.abrirBaseDeDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 404);
            this.Controls.Add(this.lblGuion);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblVigente);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padron Beta 0.2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblVigente;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alicuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroRetencion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

