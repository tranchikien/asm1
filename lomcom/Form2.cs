using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lomcom
{
    public partial class BillForm : Form
    {
        public BillForm(string customerName, string phoneNumber, string address, string taxCode,
                        double lastMonthReading, double thisMonthReading,
                        double consumption, double totalBill,
                        double environmentFee, double VAT, double finalTotal)
        {
            InitializeComponent();
            // Set up the ListView
            // Set the view to Details
            listViewBill.View = View.Details; 

            // Add columns to the ListView
            listViewBill.Columns.Add("Customer Information", 200); // Column for labels
            listViewBill.Columns.Add("Details", 200); // Column for values

            // Populate the ListView with data
            AddBillDetails(customerName, phoneNumber, address, taxCode,
                            lastMonthReading, thisMonthReading,
                            consumption, totalBill,
                            environmentFee, VAT, finalTotal);
        }


        private void AddBillDetails(string customerName, string phoneNumber, string address, string taxCode,
                                     double lastMonthReading, double thisMonthReading,
                                     double consumption, double totalBill,
                                     double environmentFee, double VAT, double finalTotal)
        {
            // Add customer info
            listViewBill.Items.Add(new ListViewItem(new[] { "Customer Name", customerName }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Phone Number", phoneNumber }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Address", address }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Tax Code", taxCode }));

            // Add usage info
            listViewBill.Items.Add(new ListViewItem(new[] { "Last Month Reading", lastMonthReading.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "This Month Reading", thisMonthReading.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Consumption", consumption.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Total Bill", totalBill.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Environment Fee", environmentFee.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "VAT", VAT.ToString() }));
            listViewBill.Items.Add(new ListViewItem(new[] { "Final Total", finalTotal.ToString() }));

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
