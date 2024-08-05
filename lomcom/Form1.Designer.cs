namespace lomcom
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.lblCustomeType = new System.Windows.Forms.Label();
            this.lblLastMonthReading = new System.Windows.Forms.Label();
            this.lblThisMonthReading = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtLastMonthReading = new System.Windows.Forms.TextBox();
            this.txtThisMonthReading = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWaterBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(27, 60);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(101, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(34, 93);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(94, 16);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "PhoneNumber";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(34, 143);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Location = new System.Drawing.Point(34, 190);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(63, 16);
            this.lblTaxCode.TabIndex = 3;
            this.lblTaxCode.Text = "TaxCode";
            // 
            // lblCustomeType
            // 
            this.lblCustomeType.AutoSize = true;
            this.lblCustomeType.Location = new System.Drawing.Point(407, 98);
            this.lblCustomeType.Name = "lblCustomeType";
            this.lblCustomeType.Size = new System.Drawing.Size(95, 16);
            this.lblCustomeType.TabIndex = 4;
            this.lblCustomeType.Text = "Custome Type";
            // 
            // lblLastMonthReading
            // 
            this.lblLastMonthReading.AutoSize = true;
            this.lblLastMonthReading.Location = new System.Drawing.Point(408, 146);
            this.lblLastMonthReading.Name = "lblLastMonthReading";
            this.lblLastMonthReading.Size = new System.Drawing.Size(126, 16);
            this.lblLastMonthReading.TabIndex = 5;
            this.lblLastMonthReading.Text = "Last Month Reading";
            // 
            // lblThisMonthReading
            // 
            this.lblThisMonthReading.AutoSize = true;
            this.lblThisMonthReading.Location = new System.Drawing.Point(407, 187);
            this.lblThisMonthReading.Name = "lblThisMonthReading";
            this.lblThisMonthReading.Size = new System.Drawing.Size(127, 16);
            this.lblThisMonthReading.TabIndex = 6;
            this.lblThisMonthReading.Text = "This Month Reading";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Household",
            "Administrative",
            "Production",
            "Business"});
            this.cmbCustomerType.Location = new System.Drawing.Point(561, 90);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(170, 24);
            this.cmbCustomerType.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(37, 243);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(165, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(179, 22);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(165, 98);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(179, 22);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(165, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 22);
            this.txtAddress.TabIndex = 12;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(165, 187);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(179, 22);
            this.txtTaxCode.TabIndex = 13;
            // 
            // txtLastMonthReading
            // 
            this.txtLastMonthReading.Location = new System.Drawing.Point(561, 143);
            this.txtLastMonthReading.Name = "txtLastMonthReading";
            this.txtLastMonthReading.Size = new System.Drawing.Size(170, 22);
            this.txtLastMonthReading.TabIndex = 14;
            // 
            // txtThisMonthReading
            // 
            this.txtThisMonthReading.Location = new System.Drawing.Point(561, 187);
            this.txtThisMonthReading.Name = "txtThisMonthReading";
            this.txtThisMonthReading.Size = new System.Drawing.Size(170, 22);
            this.txtThisMonthReading.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 294);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(767, 154);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(347, 243);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(519, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 21;
            // 
            // lblWaterBill
            // 
            this.lblWaterBill.AutoSize = true;
            this.lblWaterBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBill.Location = new System.Drawing.Point(381, 9);
            this.lblWaterBill.Name = "lblWaterBill";
            this.lblWaterBill.Size = new System.Drawing.Size(175, 42);
            this.lblWaterBill.TabIndex = 22;
            this.lblWaterBill.Text = "WaterBill";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.lblWaterBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtThisMonthReading);
            this.Controls.Add(this.txtLastMonthReading);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.lblThisMonthReading);
            this.Controls.Add(this.lblLastMonthReading);
            this.Controls.Add(this.lblCustomeType);
            this.Controls.Add(this.lblTaxCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.Label lblCustomeType;
        private System.Windows.Forms.Label lblLastMonthReading;
        private System.Windows.Forms.Label lblThisMonthReading;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.TextBox txtLastMonthReading;
        private System.Windows.Forms.TextBox txtThisMonthReading;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaterBill;
    }
}

