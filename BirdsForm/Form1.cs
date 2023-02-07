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
using System.Windows.Forms.VisualStyles;
using ClassLibrary1;

namespace BirdsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this code runs before the first screen is drawn

            // populate the first of 3 listBox's  (NOT commboboxes, we want to se listBox
            // create a list of objects of type Region (which I had to define)
            // and then ask the SQL method GetRegions to popluate with this call
            List<Regions> RegionList = DBaccess.GetRegions();
           
            // now set up the listBox to get its data from that List
            listBoxRegions.DataSource = RegionList;

            // and set the hidden, corresponding value to be the DB key value for that Name
            listBoxRegions.ValueMember = "RegionID";

            // tell it to show the Name property to the user
            listBoxRegions.DisplayMember = "RegionName";

            //====================================================================

            List<Bird> BirdList = DBaccess.GetBird();
            //DataSet BirdList = DBaccess.GetBirds();

            // now set up the listBox to get its data from that List

            listBoxBird.DataSource = BirdList;

            listBoxBird.ValueMember = "BirdID";
            // and set the hidden, corresponding value to be the DB key value for that Name

            listBoxBird.DisplayMember = "Name";
            // tell it to show the Name property to the user
         
            //==============================================
         

            // now set up the listBox to get its data from that List
           List<Birder> BirderList = DBaccess.GetBirder();

            // and set the hidden, corresponding value to be the DB key value for that Name
           listBoxBirder.DataSource = BirderList;

            // tell it to show the Name property to the user

            listBoxBirder.ValueMember = "BirderID";

            //=====================================
            listBoxBirder.DisplayMember = "BirderName";

            // need to repeat that sort of code after you add 2 new listBox's named listBoxBirds and listBox Birders.
            // You also have to define two new Classes, Bird and Birder as I did for a new Region class

            textBoxDate.Text = DateTime.Now.Date.ToString("MM/dd/yyyy");
            //Console.WriteLine(DateTime.Now.Date);

            updateScreen();
        }

        private void updateScreen()
        {
            dataGridView1.DataSource = DBaccess.GetCountData();
            dataGridView1.AutoResizeColumns();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            CountRow addCountRow = new CountRow();
            addCountRow.RegionID = (listBoxRegions.SelectedValue).ToString();
            addCountRow.BirderID = listBoxBirder.SelectedIndex;//  <<<<<<<<   need to change this to get value from a new listBoxBirders
            addCountRow.BirdID = listBoxBird.SelectedValue.ToString();
            addCountRow.Count = Convert.ToInt32(textBoxCount.Text);
            addCountRow.CountDate = Convert.ToDateTime(textBoxDate.Text);
            DBaccess.AddCount(addCountRow);
            // refresh the display
            updateScreen();
        }

        private void buttonAddRegion_Click(object sender, EventArgs e)
        {
            new FormNewRegion().Show();
        }

        private void buttonAddBirdType_Click(object sender, EventArgs e)
        {
            new FormNewBird().Show();
        }

        private void buttonAddBirder_Click(object sender, EventArgs e)
        {
            new FormNewBirder().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RelatedTablesForm().Show();
        }

        private void homeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NavigationForm().ShowDialog();
        }
    }
}
