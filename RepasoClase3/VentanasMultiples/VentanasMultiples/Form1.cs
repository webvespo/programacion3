namespace VentanasMultiples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVentana1 frm = new FormVentana1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVentana2 frm = new FormVentana2();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}