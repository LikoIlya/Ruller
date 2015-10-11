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
    public enum TypeAlignCfg
    {
        Left,
        Right
    }

    public enum TypeCompare
    {
        FirstParents,
        FirstChild
    }

    public enum TypeSorted
    {
        Up,
        Down
    }
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
    }

}
