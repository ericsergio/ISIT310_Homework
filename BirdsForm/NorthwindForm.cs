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
            DataClassDataContext context = new DataClassDataContext();
            string orderDisplay = "City\t\tDate\t\tCompany\t\tShipping Company";

            var orders = from o in context.Orders
                         //************************I pushed these changes late, I originally had the join but fixed it.
                         //join c in context.Customers
                         //on o.CustomerID equals c.CustomerID
                         //join s in context.Shippers
                         //on o.ShipVia equals s.ShipperID
                         where o.ShipCity == "Seattle" || o.ShipCity == "Portland"
                         orderby o.ShipCity, o.ShippedDate ascending
                         select new { 
                             City = o.ShipCity, 
                             Date = o.ShippedDate,
                             CompanyName = o.Customer.CompanyName,
                             ShipperName = o.Shipper.CompanyName,
                             //ShipName = o.ShipName
                             
                             
                         };

            foreach (var order in orders)
            {
                orderDisplay += order.City.ToString() + "\t\t\t" + order.Date + "\t\t\t" + order.CompanyName + "\t\t\t" + order.ShipperName;
            }
            grid1.DataSource = orders;
        }
    }
}
