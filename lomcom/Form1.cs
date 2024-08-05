using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace lomcom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("customerName", 100);
            listView1.Columns.Add("phoneNumber", 100);
            listView1.Columns.Add("address", 100);
            listView1.Columns.Add("taxCode", 100);
            listView1.Columns.Add("customerType", 100);
        }

        private double CalculateBill(string customerType, double consumption)
        {
            switch (customerType)
            {
                case "Household":
                    return consumption * 5973;
                case "Administrative":
                    return consumption * 9955;
                case "Production":
                    return consumption * 11615;
                case "Business":
                    return consumption * 22068;
                default:
                    throw new ArgumentException("Invalid customer type");
                    
            }
        }
        private double CalculateEnvironmentFee(double totalBill)
        {
            return totalBill * 0.1;
        }

        private double CalculateVAT(double subTotal)
        {
            return subTotal * 0.1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
            // Gather input data
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string taxCode = txtTaxCode.Text;
            // Validate readings - Check if they are numbers
            if (!double.TryParse(txtLastMonthReading.Text, out double lastMonthReading))
            {
                MessageBox.Show("Last month's reading must be a number.");
                return;
            }

            if (!double.TryParse(txtThisMonthReading.Text, out double thisMonthReading))
            {
                MessageBox.Show("This month's reading must be a number.");
                return;
            }
            string customerType = cmbCustomerType.SelectedItem.ToString();
           
            // Calculate bill
            double consumption = thisMonthReading - lastMonthReading;
            double totalBill = CalculateBill(customerType, consumption);
            double environmentFee = CalculateEnvironmentFee(totalBill);
            double subTotal = totalBill + environmentFee;
            double VAT = CalculateVAT(subTotal);
            double finalTotal = subTotal + VAT;

            // Validate readings
            if (thisMonthReading <= 0 || lastMonthReading <= 0)
            {
                MessageBox.Show("Last month's and this month's readings must be greater than 0.");
                return;
            }

            if (thisMonthReading < lastMonthReading)
            {
                MessageBox.Show("This month's meter reading must be greater than or equal to last month's reading.");
                return;
            }

            // Show bill in a new form
            BillForm billForm = new BillForm(customerName, phoneNumber, address, taxCode,
                                              lastMonthReading, thisMonthReading,
                                              consumption, totalBill,
                                              environmentFee, VAT, finalTotal);
            billForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Gather input data
            string customerName = txtCustomerName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string taxCode = txtTaxCode.Text;

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber)
                || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(taxCode))
            {
                MessageBox.Show("Please enter full information");
                return;
            }
           
            string txtlast = txtLastMonthReading.Text;
            string thisW = txtThisMonthReading.Text;
            //string customerType = cmbCustomerType.SelectedItem.ToString();
            string btType = null;
            if (cmbCustomerType.SelectedIndex == 0)
            {
                btType = "Household";
            }
            else if (cmbCustomerType.SelectedIndex == 1)
            {
                btType = "Administrative";
            }
            else if (cmbCustomerType.SelectedIndex == 2)
            {
                btType = "Production";
            }
            else if (cmbCustomerType.SelectedIndex == 3)
            {
                btType = "Business";
            }

            // Đẩy dữ liệu đã lấy được trên form vào đối tượng ListViewItem
            //Khai báo đối tượng mới
            ListViewItem item = new ListViewItem();
            item.Text = customerName;
            item.SubItems.Add(phoneNumber);
            item.SubItems.Add(address);
            item.SubItems.Add(taxCode);
            item.SubItems.Add(btType);
            item.SubItems.Add(txtlast);
            listView1.Items.Add(item);

           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một mục để chỉnh sửa");
                return;
            }
            
                ListViewItem item = listView1.SelectedItems[0];
                item.SubItems.Clear();

                // Gather input data
                string customerName = txtCustomerName.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string address = txtAddress.Text;
                string taxCode = txtTaxCode.Text;
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) || 
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(taxCode))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

                string txtlast = txtLastMonthReading.Text;
                string thisW = txtThisMonthReading.Text;
                string btType = null;   
                if (cmbCustomerType.SelectedIndex == 0)
                {
                    btType = "Household";
                }
                else if (cmbCustomerType.SelectedIndex == 1)
                {
                    btType = "Administrative";
                }
                else if (cmbCustomerType.SelectedIndex == 2)
                {
                    btType = "Production";
                }
                else if (cmbCustomerType.SelectedIndex == 3)
                {
                    btType = "Business";
                }

                // Đẩy dữ liệu đã lấy được trên form vào đối tượng ListViewItem
                //Khai báo đối tượng mới

                item.Text = customerName;
                item.SubItems.Add(phoneNumber);
                item.SubItems.Add(address);
                item.SubItems.Add(taxCode);
                item.SubItems.Add(btType);
                item.SubItems.Add(txtlast);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = null;
            txtPhoneNumber.Text = null;
            txtAddress.Text = null;
            cmbCustomerType.Text = null;
            txtTaxCode.Text = null;
            txtLastMonthReading.Text = null;
            txtThisMonthReading.Text = null;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {  
                ListViewItem seleted_Item = listView1.SelectedItems[0];
                //kiểm tra lại
                string customerName = seleted_Item.SubItems[0].Text;
                string phoneNumber = seleted_Item.SubItems[1].Text;
                string address = seleted_Item.SubItems[2].Text;
                string taxCode = seleted_Item.SubItems[3].Text;

                txtCustomerName.Text = customerName;
                txtPhoneNumber.Text = phoneNumber;
                txtAddress.Text = address;
                txtTaxCode.Text = taxCode;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
          Application.Exit();
            
        }
    }
}
