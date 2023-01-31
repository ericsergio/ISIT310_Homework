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
    public partial class NorthwindForm : Form
    {
        public NorthwindForm()
        {
            InitializeComponent();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NavigationForm().ShowDialog();
        }

        private void NorthwindForm_Load(object sender, EventArgs e)
        {
            DataClassDataContext dataContext = new DataClassDataContext();
            string orderDisplay = "City\t\tDate\t\tCompany\t\tShipping Company";

            var orders = from myOrders in dataContext.Orders
                         join customers in dataContext.Customers
                         on myOrders.CustomerID equals customers.CustomerID
                         join shippers in dataContext.Shippers
                         on myOrders.ShipVia equals shippers.ShipperID
                         where myOrders.ShipCity == "Seattle" || myOrders.ShipCity == "Portland"
                         orderby myOrders.ShipCity, myOrders.ShippedDate ascending
                         select new { 
                             City = myOrders.ShipCity, 
                             Date = myOrders.ShippedDate,
                             CompanyName = customers.CompanyName,
                             ShipperName = shippers.CompanyName
                             
                             
                         };

            foreach ( var order in orders )
            {
                orderDisplay += order.City.ToString() + "\t\t\t" + order.Date + "\t\t\t" + order.CompanyName + "\t\t\t" + order.ShipperName;
            }
            grid1.DataSource = orders;
        }
    }
}
