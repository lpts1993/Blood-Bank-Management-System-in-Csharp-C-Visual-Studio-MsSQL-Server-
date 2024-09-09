namespace ProyectoCompleto
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarDonadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicaionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeSandreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disminusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDonadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donarToolStripMenuItem,
            this.buscarDonadorToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.eliminarDonadorToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1183, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donarToolStripMenuItem
            // 
            this.donarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem,
            this.cargarDetallesToolStripMenuItem,
            this.todosLosDetallesToolStripMenuItem});
            this.donarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.donarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("donarToolStripMenuItem.Image")));
            this.donarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.donarToolStripMenuItem.Name = "donarToolStripMenuItem";
            this.donarToolStripMenuItem.Size = new System.Drawing.Size(94, 55);
            this.donarToolStripMenuItem.Text = "Donar";
            this.donarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.donarToolStripMenuItem.Click += new System.EventHandler(this.donarToolStripMenuItem_Click);
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarNuevoToolStripMenuItem.Image")));
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar Nuevo";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // cargarDetallesToolStripMenuItem
            // 
            this.cargarDetallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cargarDetallesToolStripMenuItem.Image")));
            this.cargarDetallesToolStripMenuItem.Name = "cargarDetallesToolStripMenuItem";
            this.cargarDetallesToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.cargarDetallesToolStripMenuItem.Text = "Editar Detalles";
            this.cargarDetallesToolStripMenuItem.Click += new System.EventHandler(this.cargarDetallesToolStripMenuItem_Click);
            // 
            // todosLosDetallesToolStripMenuItem
            // 
            this.todosLosDetallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todosLosDetallesToolStripMenuItem.Image")));
            this.todosLosDetallesToolStripMenuItem.Name = "todosLosDetallesToolStripMenuItem";
            this.todosLosDetallesToolStripMenuItem.Size = new System.Drawing.Size(294, 36);
            this.todosLosDetallesToolStripMenuItem.Text = "Todos los Detalles";
            this.todosLosDetallesToolStripMenuItem.Click += new System.EventHandler(this.todosLosDetallesToolStripMenuItem_Click);
            // 
            // buscarDonadorToolStripMenuItem
            // 
            this.buscarDonadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ubicaionToolStripMenuItem,
            this.tipoDeSandreToolStripMenuItem});
            this.buscarDonadorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buscarDonadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarDonadorToolStripMenuItem.Image")));
            this.buscarDonadorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buscarDonadorToolStripMenuItem.Name = "buscarDonadorToolStripMenuItem";
            this.buscarDonadorToolStripMenuItem.Size = new System.Drawing.Size(199, 55);
            this.buscarDonadorToolStripMenuItem.Text = "Buscar Donador";
            this.buscarDonadorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ubicaionToolStripMenuItem
            // 
            this.ubicaionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ubicaionToolStripMenuItem.Image")));
            this.ubicaionToolStripMenuItem.Name = "ubicaionToolStripMenuItem";
            this.ubicaionToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.ubicaionToolStripMenuItem.Text = "Ubicaion";
            this.ubicaionToolStripMenuItem.Click += new System.EventHandler(this.ubicaionToolStripMenuItem_Click);
            // 
            // tipoDeSandreToolStripMenuItem
            // 
            this.tipoDeSandreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoDeSandreToolStripMenuItem.Image")));
            this.tipoDeSandreToolStripMenuItem.Name = "tipoDeSandreToolStripMenuItem";
            this.tipoDeSandreToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.tipoDeSandreToolStripMenuItem.Text = "Tipo de Sandre";
            this.tipoDeSandreToolStripMenuItem.Click += new System.EventHandler(this.tipoDeSandreToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aumentoToolStripMenuItem,
            this.disminusionToolStripMenuItem,
            this.detallesToolStripMenuItem});
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stockToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockToolStripMenuItem.Image")));
            this.stockToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(87, 55);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // aumentoToolStripMenuItem
            // 
            this.aumentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aumentoToolStripMenuItem.Image")));
            this.aumentoToolStripMenuItem.Name = "aumentoToolStripMenuItem";
            this.aumentoToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.aumentoToolStripMenuItem.Text = "Aumento";
            this.aumentoToolStripMenuItem.Click += new System.EventHandler(this.aumentoToolStripMenuItem_Click);
            // 
            // disminusionToolStripMenuItem
            // 
            this.disminusionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disminusionToolStripMenuItem.Image")));
            this.disminusionToolStripMenuItem.Name = "disminusionToolStripMenuItem";
            this.disminusionToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.disminusionToolStripMenuItem.Text = "Disminusion";
            this.disminusionToolStripMenuItem.Click += new System.EventHandler(this.disminusionToolStripMenuItem_Click);
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detallesToolStripMenuItem.Image")));
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(237, 36);
            this.detallesToolStripMenuItem.Text = "Detalles";
            this.detallesToolStripMenuItem.Click += new System.EventHandler(this.detallesToolStripMenuItem_Click);
            // 
            // eliminarDonadorToolStripMenuItem
            // 
            this.eliminarDonadorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eliminarDonadorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarDonadorToolStripMenuItem.Image")));
            this.eliminarDonadorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarDonadorToolStripMenuItem.Name = "eliminarDonadorToolStripMenuItem";
            this.eliminarDonadorToolStripMenuItem.Size = new System.Drawing.Size(217, 55);
            this.eliminarDonadorToolStripMenuItem.Text = "Eliminar Donador";
            this.eliminarDonadorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarDonadorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eliminarDonadorToolStripMenuItem.Click += new System.EventHandler(this.eliminarDonadorToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cerrarSesionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesionToolStripMenuItem.Image")));
            this.cerrarSesionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(169, 55);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cerrarSesionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1144, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 772);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem donarToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private ToolStripMenuItem cargarDetallesToolStripMenuItem;
        private ToolStripMenuItem todosLosDetallesToolStripMenuItem;
        private ToolStripMenuItem buscarDonadorToolStripMenuItem;
        private ToolStripMenuItem ubicaionToolStripMenuItem;
        private ToolStripMenuItem tipoDeSandreToolStripMenuItem;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem aumentoToolStripMenuItem;
        private ToolStripMenuItem disminusionToolStripMenuItem;
        private ToolStripMenuItem detallesToolStripMenuItem;
        private ToolStripMenuItem eliminarDonadorToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}