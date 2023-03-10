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
    public partial class Homework5 : Form
    {
        public Homework5()
        {
            InitializeComponent();
        }

        private void homeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NavigationForm().ShowDialog();
        }

        private void Homework5_Load(object sender, EventArgs e)
        {
            BirdsEntities1 entityContext = new BirdsEntities1();

            var birdCountBirders =
                from eachCountedBird in entityContext.BirdCounts
                orderby eachCountedBird.Counted ascending
                select new
                {
                    BirdID = eachCountedBird.BirderID,
                    eachCountedBird.Counted,
                    Name = eachCountedBird.Bird.Name.ToString()
                };            
            gridEntityData.DataSource = birdCountBirders.ToList();
        }
    }
}
