using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_pbo
{
    public partial class Loginn : Form
    {
        public Loginn()
        {
            InitializeComponent();
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //private string bigTextBox1_Text;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kode_verifikasi kode_Verifikasi = new kode_verifikasi();
            kode_Verifikasi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
