using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAppMulti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void abrirVentanita(object ventanita)
        {
            if (this.panelBox.Controls.Count > 0)
                this.panelBox.Controls.RemoveAt(0);
            Form fventanita = ventanita as Form;
            fventanita.TopLevel = false;
            fventanita.Dock = DockStyle.Fill;
            this.panelBox.Controls.Add(fventanita);
            this.panelBox.Tag = fventanita;
            fventanita.Show();
        }
        private void nuevaVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentanita(new Ventanita());
        }
    }
}
