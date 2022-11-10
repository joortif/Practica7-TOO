namespace Pract7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.boton = new System.Windows.Forms.ToolStripButton();
            this.etiqueta = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botonSplit = new System.Windows.Forms.ToolStripSplitButton();
            this.botonDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.opción1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opción3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arribaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarBarraDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStrip2;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boton,
            this.etiqueta,
            this.toolStripSeparator1,
            this.botonSplit,
            this.botonDropDown,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // boton
            // 
            this.boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boton.Image = ((System.Drawing.Image)(resources.GetObject("boton.Image")));
            this.boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(23, 22);
            this.boton.Text = "boton";
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // etiqueta
            // 
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.Size = new System.Drawing.Size(50, 22);
            this.etiqueta.Text = "etiqueta";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // botonSplit
            // 
            this.botonSplit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonSplit.DropDown = this.contextMenuStrip1;
            this.botonSplit.Image = ((System.Drawing.Image)(resources.GetObject("botonSplit.Image")));
            this.botonSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonSplit.Name = "botonSplit";
            this.botonSplit.Size = new System.Drawing.Size(32, 22);
            this.botonSplit.Text = "toolStripSplitButton1";
            this.botonSplit.ButtonClick += new System.EventHandler(this.botonSplit_ButtonClick);
            // 
            // botonDropDown
            // 
            this.botonDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonDropDown.Image = ((System.Drawing.Image)(resources.GetObject("botonDropDown.Image")));
            this.botonDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonDropDown.Name = "botonDropDown";
            this.botonDropDown.Size = new System.Drawing.Size(29, 22);
            this.botonDropDown.Text = "toolStripDropDownButton1";
            this.botonDropDown.Click += new System.EventHandler(this.botonDropDown_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opción1ToolStripMenuItem,
            this.opción2ToolStripMenuItem,
            this.opción3ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arribaToolStripMenuItem,
            this.abajoToolStripMenuItem,
            this.izquierdaToolStripMenuItem,
            this.derechaToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 92);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verBarraDeHerramientasToolStripMenuItem,
            this.ocultarBarraDeHerramientasToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(232, 48);
            // 
            // opción1ToolStripMenuItem
            // 
            this.opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            this.opción1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opción1ToolStripMenuItem.Text = "Opción 1";
            // 
            // opción2ToolStripMenuItem
            // 
            this.opción2ToolStripMenuItem.Name = "opción2ToolStripMenuItem";
            this.opción2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opción2ToolStripMenuItem.Text = "Opción 2";
            // 
            // opción3ToolStripMenuItem
            // 
            this.opción3ToolStripMenuItem.Name = "opción3ToolStripMenuItem";
            this.opción3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opción3ToolStripMenuItem.Text = "Opción 3";
            // 
            // arribaToolStripMenuItem
            // 
            this.arribaToolStripMenuItem.Name = "arribaToolStripMenuItem";
            this.arribaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arribaToolStripMenuItem.Text = "Arriba";
            // 
            // abajoToolStripMenuItem
            // 
            this.abajoToolStripMenuItem.Name = "abajoToolStripMenuItem";
            this.abajoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.abajoToolStripMenuItem.Text = "Abajo";
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.izquierdaToolStripMenuItem.Text = "Izquierda";
            // 
            // derechaToolStripMenuItem
            // 
            this.derechaToolStripMenuItem.Name = "derechaToolStripMenuItem";
            this.derechaToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.derechaToolStripMenuItem.Text = "Derecha";
            // 
            // verBarraDeHerramientasToolStripMenuItem
            // 
            this.verBarraDeHerramientasToolStripMenuItem.Name = "verBarraDeHerramientasToolStripMenuItem";
            this.verBarraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.verBarraDeHerramientasToolStripMenuItem.Text = "Ver barra de herramientas";
            this.verBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.verBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // ocultarBarraDeHerramientasToolStripMenuItem
            // 
            this.ocultarBarraDeHerramientasToolStripMenuItem.Name = "ocultarBarraDeHerramientasToolStripMenuItem";
            this.ocultarBarraDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.ocultarBarraDeHerramientasToolStripMenuItem.Text = "Ocultar barra de herramientas";
            this.ocultarBarraDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.ocultarBarraDeHerramientasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton boton;
        private System.Windows.Forms.ToolStripLabel etiqueta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton botonSplit;
        private System.Windows.Forms.ToolStripDropDownButton botonDropDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opción1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opción3ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem arribaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derechaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem verBarraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarBarraDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

