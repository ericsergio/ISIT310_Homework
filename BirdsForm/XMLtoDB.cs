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
        private DataSet birdDataSet;
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
            birdDataSet = DBaccess.GetBirds();

            gridSQL.DataSource = birdDataSet;
            gridSQL.DataMember = "BirdCount";
        }
        private void saveXml_Click(object sender, EventArgs e)
        {
            DataSet xmlData = new DataSet();
            xmlData.ReadXml(xmlFile);
            DBaccess.DoXML(xmlData);
        }
    }
}