﻿using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework6
{
    public partial class Form2 : Form
    {
        private string connectStr = "server=127.0.0.1;port=3306;user=root;password=1119;database=orderapp";
        public Form2()
        {
            InitializeComponent();
        }

        private void admit_button_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer(idtext.Text, customtext.Text);
                Goods goods = new Goods(goodId_text.Text, goodName_text.Text, Convert.ToInt32(price_text.Text));
                Order order = new Order(Convert.ToInt32(idtext.Text), customer, DateTime.Now);
                OrderDetail detail = new OrderDetail(goods, 1);
                order.AddDetails(detail);
                OrderForm.orderService.AddOrder(order);
                string addStr = $"insert into order(id,creatTime,price,customerId) values('{idtext.Text}','{time_text.Text}'," + $"'{price_text.Text}',{int.Parse(goodId_text.Text)});";
                MySqlOpHelper msop = new MySqlOpHelper(connectStr);
                msop.OpAddDeleUpdateMySql(addStr);
                //idtext.Text = "";
                //time_text.Text = "";
                //price_text.Text = "";
                //goodId_text.Text = "";
                MessageBox.Show("添加成功");
            }
            catch
            {
                MessageBox.Show("请重新输入！");
            }
            OrderForm f1 = new OrderForm();
            this.Hide();
            f1.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OrderForm.orderService.RemoveOrder(Convert.ToInt32(idtext.Text));
                MessageBox.Show("删除成功");
            }
            catch
            {
                MessageBox.Show("请重新输入！");
            }
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            idtext.Text = null;
            customtext.Text = null;
            price_text.Text = null;
            goodId_text.Text = null;
            goodName_text.Text = null;
            time_text.Text = null;
        }
    }
}