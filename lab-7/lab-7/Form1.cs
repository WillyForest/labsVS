using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab_7
{
    public partial class Form1 : Form
    {
        private Lab7BaseEntities2 dataModel;
        BindingSource brandBs, classBs, toolBs, customerBs, receiptBs, warrantyBs, supplierBs;
        public Form1()
        {
            InitializeComponent();

            dataModel = new Lab7BaseEntities2();

            brandBs = new BindingSource();
            brandBs.DataSource = dataModel.Brand;
            
            //First open tab
            bindingNavigator1.BindingSource = brandBs;
            brandDgw.DataSource = brandBs;

            supplierBs = new BindingSource();
            supplierBs.DataSource = dataModel.Supplier;
            supplierDgw.DataSource = supplierBs; 
            
            classBs = new BindingSource();
            classBs.DataSource = dataModel.Class;
            classDgw.DataSource = classBs;

            toolBs = new BindingSource();
            toolBs.DataSource = dataModel.Tool;
            toolDgw.DataSource = toolBs;

            customerBs = new BindingSource();
            customerBs.DataSource = dataModel.Customer;
            customerDgw.DataSource = customerBs;

            receiptBs = new BindingSource();
            receiptBs.DataSource = dataModel.Receipt;
            receiptDgw.DataSource = receiptBs;

            warrantyBs = new BindingSource();
            warrantyBs.DataSource = dataModel.Warranty;
            warrantyDgw.DataSource = warrantyBs;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    bindingNavigator1.BindingSource = brandBs;
                    break;
                case 1:
                    bindingNavigator1.BindingSource = supplierBs;
                    break;
                case 2:
                    bindingNavigator1.BindingSource = classBs;
                    break;
                case 3:
                    bindingNavigator1.BindingSource = toolBs;
                    break;
                case 4:
                    bindingNavigator1.BindingSource = customerBs;
                    break;
                case 5:
                    bindingNavigator1.BindingSource = receiptBs;
                    break;
                case 6:
                    bindingNavigator1.BindingSource = warrantyBs;
                    break;
            };
        }
    }
}
