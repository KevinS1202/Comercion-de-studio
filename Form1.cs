using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cpecialBtn_Click(object sender, EventArgs e)
        {
            using (Form2 ventanaSpecial = new Form2())
                ventanaSpecial.ShowDialog();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            using (Form3 ventanaStudent = new Form3())
                ventanaStudent.ShowDialog();
        }

        private void buchenBtn_Click(object sender, EventArgs e)
        {
            using (Form4 ventanaObuchen = new Form4())
                ventanaObuchen.ShowDialog();
        }
    }
}
