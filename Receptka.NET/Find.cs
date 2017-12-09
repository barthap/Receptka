using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Receptka
{
    public partial class FindDialog : Form
    {
        public FindDialog()
        {
            InitializeComponent();
        }
        private void CloseDialog(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindSearchButton_Click(object sender, EventArgs e)
        {
            //znajdz(textBox1.Text);
        }
    }
}
