﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;
using Microsoft.VisualBasic;

namespace ChapeauUI
{
    public partial class Bill : Form
    {
        BillService billService;
        ChapeauModel.Bill bill;

       

        public Bill()
        {
            InitializeComponent();
            billService = new BillService();
            bill = new ChapeauModel.Bill();
        }

        private void btn_paidCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Check Terminal");
        }

        private void btn_paidCash_Click(object sender, EventArgs e)
        {
            (new Bill_PaidInCash()).Show(); this.Hide();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            /*
            List<Order> items = billService.OrderItems();
            List<OrderItem> orderOverview = billService.OrderOverview();

            foreach (Order item in items)
            {
                lbl_BillId.Text = $"{item.BillID}";
                lbl_table.Text = $"{item.Table_Number}";
                lbl_hostname.Text = $"{item.Employee_Number.First_Name}";
            }
            foreach (OrderItem item in orderOverview)
            {
                lbl_orderview.Text = $"{item.MenuItemID.Menu_Item_Name}       X{item.Quantity}     €{item.MenuItemID.Menu_Item_Price * item.Quantity}";
            }
            lbl_VAT.Text = $"€ {billService.VatDrinks()}";
            lbl_total.Text = $"€{billService.CalculateBill()}";
            billService.GetBills();
            billService.AddtoPayment(bill);
            */
        }

        //sasa added logout 
        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginpage = new Login();
                loginpage.ShowDialog();
                this.Close();
            }
        }
    }
}