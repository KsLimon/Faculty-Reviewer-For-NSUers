using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Faculty_review
{
    public partial class EvaluateFaculty : Form
    {

        string connectionString = string.Format(
               "server={0};uid={1};pwd={2};database={3}",
               "localhost",
               "root",
               "1813059642",
               "frapp"
               );

        public static int r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0, r10 = 0, r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0;

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            r6 = 2;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            r7 = 2;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            r8 = 2;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            r9 = 2;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            r10 = 2;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            r11 = 2;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            r12 = 2;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            r13 = 2;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            r14 = 2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int teaching = r1 + r2 + r3 + r4 + r5;
            int bhve = r6 + r7 + r8 + r9 + r14;
            int grd = r10 + r11 + r12 + r13 + r15;
            MessageBox.Show("t=" + teaching + ", b=" + bhve + ", g=" + grd);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            r15 = 2;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            r5 = 2;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            r4 = 2;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            r3 = 2;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            r1 = 2;
        }

        public EvaluateFaculty()
        {
            InitializeComponent();

            label3.Text = Login.name;
            label6.Text = Search.fac_ini;
            label8.Text = Search.fac_name;

            if (Login.typ == "1")
            {
                label2.Text = "Administrator";
            }
            else if (Login.typ == "2")
            {
                label2.Text = "Faculty";
            }
            else
            {
                label2.Text = "Student";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void EvaluateFaculty_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            r2 = 2;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
