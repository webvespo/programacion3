﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_funcionando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newChild = new Form2();
            newChild.MdiParent = this;
            newChild.Show();
        }
    }
}
