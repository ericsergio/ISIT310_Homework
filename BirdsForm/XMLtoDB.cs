using BirdsForm.BirdsDataSetTableAdapters;
using DbLib;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BirdsForm
{
    public partial class XMLtoDB : Form
    {
        private DataSet birdsDataSet;
        private const String xmlFile = @"Y:\Documents\School\23\Winter\isit310\docs\RemoteBirdClub.xml";


        public XMLtoDB()
        {
            InitializeComponent();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NavigationForm().ShowDialog();
        }

        private void showXml_Click(object sender, EventArgs e)
        {
            DataSet xmlData = new DataSet();
            xmlData.ReadXml(xmlFile);
            gridXML.DataSource = xmlData.Tables[0];
        }

        private void showDb_Click(object sender, EventArgs e)
        {
            birdsDataSet = DBaccess.GetBirds();

            gridSQL.DataSource = birdsDataSet;
            gridSQL.DataMember = "BirdCount";
        }
        private void saveXml_Click(object sender, EventArgs e)
        {
            /*was just testing -- do not think any of this correct*/
            //string xmlData = null;
            IList xmlData = DBaccess.GetCountData();
            foreach(int prop in xmlData)
            {
                Console.WriteLine(prop);
            }
            //MessageBox.Show(xmlData, "CountDataSet");
            //MessageBox.Show(xmlData.ToString());

           

        }
        private void mergeXml_Click(object sender, EventArgs e)
        {
            DBaccess.doXml();
        }
    }
}