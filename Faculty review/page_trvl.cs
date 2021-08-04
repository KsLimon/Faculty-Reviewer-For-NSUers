using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_review
{
    public partial class page_trvl : Form
    {
        public page_trvl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Profile pp = new Profile();
            pp.ShowDialog();
        }

        private void page_trvl_Load(object sender, EventArgs e)
        {

        }
    }
}
