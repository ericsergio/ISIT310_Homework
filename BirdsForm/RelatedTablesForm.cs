using ClassLibrary1;
using System;
using System.Data;
using System.Windows.Forms;

namespace BirdsForm
{
    public partial class RelatedTablesForm : Form
    {
        private DataSet birdsDataSet;
        DataView BirdCount = new DataView();
        public RelatedTablesForm()
        {
            InitializeComponent();
        }

        private void RelatedTablesForm_Load(object sender, EventArgs e)
        {
            birdsDataSet = DBaccess.GetBirds();

            dataGridView1.DataSource = birdsDataSet;
            dataGridView1.DataMember = "Bird";

            dataGridView2.DataSource = birdsDataSet;
            dataGridView2.DataMember = "Bird.UsefulRelation";

            //dataGridView1.DataSource = birdsDataSet;
            //dataGridView1.DataMember = "Bird.UsefulRelation";
        }



        private void moveFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[birdsDataSet, "Bird"].Position = 0;
           
        }

        private void moveNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[birdsDataSet, "Bird"].Position += 1;
            
        }

        private void movePrev_Click(object sender, EventArgs e)
        {
            this.BindingContext[birdsDataSet, "Bird"].Position -= 1;
            
        }

        private void moveLast_Click(object sender, EventArgs e)
        {
            this.BindingContext[birdsDataSet, "Bird"].Position = this.BindingContext[birdsDataSet, "Bird"].Count - 1;
            
        }
    }
}
