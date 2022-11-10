using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton)
                {
                    item.Click -= ClickBoton;
                    item.Click += ClickBoton;
                }
            }
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void boton_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = boton.Name;
        }

        private void botonDropDown_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = boton.Name;
        }

        private void botonSplit_ButtonClick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = boton.Name;
        }

        private void ocultarBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Enabled = false;
        }

        private void verBarraDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip1.Enabled = true;
        }

        private void ClickBoton(object sender, EventArgs e)
        {
            string pos = "";
            ToolStripButton bt = (ToolStripButton)sender;
            if (bt.Name == "botonSplit")
            {
                pos = "penúltimo";
                MessageBox.Show("Se ha pulsado el " + pos + " boton");
            } else if (bt.Name == "botonDropDown")
            {
                pos = "último";
                MessageBox.Show("Se ha pulsado el " + pos + " boton");
            } else if (bt.Name == "boton")
            {
                pos = "primer";
                MessageBox.Show("Se ha pulsado el " + pos + " boton");

            }
            
        }
        

        
    }
}
