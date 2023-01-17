using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdsForm
{
    public partial class FormNewRegion : Form
    {
        public FormNewRegion()
        {
            InitializeComponent();
        }

        private void buttonNewRegion_Click(object sender, EventArgs e)
        {
            string status = DBaccess.AddRegion(textBoxRegionName.Text, textBox1.Text);
            labelStatus.Text = status;
        }
    }
}
