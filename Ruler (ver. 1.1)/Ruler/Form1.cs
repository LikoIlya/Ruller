using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void конфигурацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (configureForm == null) 
                configureForm = new Form2();
            configureForm.ShowDialog();
            if (configureForm.DialogResult == DialogResult.OK)
            {
                configureForm.Hide();
            }
        }

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 оПрограмме = new AboutBox1();
			оПрограмме.ShowDialog();
		}
    }

}
