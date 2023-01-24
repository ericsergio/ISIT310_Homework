using DbLib;
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
    public partial class FormNewBirder : Form
    {
        public FormNewBirder()
        {
            InitializeComponent();
        }

        private void buttonNewBirder_Click(object sender, EventArgs e)
        {
            string status = DBaccess.AddBirder(textBoxBirderFirstName.Text, textBoxBirderLastName.Text, textBoxBirderPhoneNumber.Text);
            labelStatus.Text = status;
        }
    }
}
