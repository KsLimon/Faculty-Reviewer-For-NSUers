using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Faculty_review
{
    public partial class cgpacalc : Form
    {
        public cgpacalc()
        {
            InitializeComponent();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            Hide();
            Search src = new Search();
            src.Show();

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            Hide();
            Search src = new Search();
            src.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
