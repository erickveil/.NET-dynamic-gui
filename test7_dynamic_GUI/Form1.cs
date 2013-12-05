using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test7_dynamic_GUI
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox tb_dynamic;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dynaform = new Form2();
            dynaform.Show();
            
        }
    }
}
