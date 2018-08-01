using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security;

namespace Input_CGNA
{
    public partial class CGNA : Form
    {
        public CGNA()
        {
            InitializeComponent();
            txt_ARQ.Tag = txt_ARQ.Text;
        }

        private void btn_Arq_Click(object sender, EventArgs e)
        {
            DialogResult rs = openFILE.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txt_ARQ.Text = openFILE.FileName;
                openFILE.Dispose();
            }
        }

        private void btn_CANC_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
        private void btn_Ini_Click(object sender, EventArgs e)
        {
            new Processa_CGNA();
        }
    }
}
