using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostV2
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        public DialogResult Show(string text, Color foreColour)
        {
            dialogLabel.Text = text;
            dialogLabel.ForeColor = foreColour;
            return this.ShowDialog();
        }
    }
}
