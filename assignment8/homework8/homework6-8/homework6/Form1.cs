using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace homework6
{
    
    public partial class OrderForm : Form
    {
        public static OrderService orderService = new OrderService();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void sort_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            orderService.SortOrder();
            List<Order> orderList2 = orderService.QueryAll();
            int i = -1;
            foreach (var item in orderList2)
            {
                this.dataGridView1.Rows.Add();
                i++;
                StringBuilder result7 = new StringBuilder();
                StringBuilder result8 = new StringBuilder();
                item.Details.ForEach(detail => result7.Append(detail.getGoodName()));
                item.Details.ForEach(detail => result8.Append(detail.getGoodId()));
                this.dataGridView1.Rows[i].Cells[0].Value = item.Id;
                this.dataGridView1.Rows[i].Cells[1].Value = item.Customer.Name;
                this.dataGridView1.Rows[i].Cells[2].Value = result7.ToString();
                this.dataGridView1.Rows[i].Cells[3].Value = result8.ToString();
                this.dataGridView1.Rows[i].Cells[4].Value = item.CreateTime;
                this.dataGridView1.Rows[i].Cells[5].Value = item.TotalPrice;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            switch (choice_text.Text)
            {
                case "id":
                    Order order1= orderService.GetById(Convert.ToInt32(search_text.Text));
                    StringBuilder result3 = new StringBuilder();
                    StringBuilder result4 = new StringBuilder();
                    order1.Details.ForEach(detail => result3.Append(detail.getGoodName()));
                    order1.Details.ForEach(detail => result4.Append(detail.getGoodId()));
                    this.dataGridView1.Rows[0].Cells[0].Value = order1.Id;
                    this.dataGridView1.Rows[0].Cells[1].Value = order1.Customer.Name;
                    this.dataGridView1.Rows[0].Cells[2].Value = result3.ToString();
                    this.dataGridView1.Rows[0].Cells[3].Value = result4.ToString();
                    this.dataGridView1.Rows[0].Cells[4].Value = order1.CreateTime;
                    this.dataGridView1.Rows[0].Cells[5].Value = order1.TotalPrice;
                    break;
                case "custom":
                    List<Order> orderList = orderService.QueryByCustomerName(search_text.Text);
                    int i = -1;
                    foreach (var item in orderList)
                    {
                        this.dataGridView1.Rows.Add();
                        i++;
                        StringBuilder result1 = new StringBuilder();
                        StringBuilder result2 = new StringBuilder();
                        item.Details.ForEach(detail => result1.Append(detail.getGoodName()));
                        item.Details.ForEach(detail => result2.Append(detail.getGoodId()));
                        this.dataGridView1.Rows[i].Cells[0].Value = item.Id;
                        this.dataGridView1.Rows[i].Cells[1].Value = item.Customer.Name;
                        this.dataGridView1.Rows[i].Cells[2].Value = result1.ToString();
                        this.dataGridView1.Rows[i].Cells[3].Value = result2.ToString();
                        this.dataGridView1.Rows[i].Cells[4].Value = item.CreateTime;
                        this.dataGridView1.Rows[i].Cells[5].Value = item.TotalPrice;
                        
                    }
                    break;
                case "price":
                    List<Order> orderList1 = orderService.QueryByTotalPrice(Convert.ToSingle(search_text.Text));
                    int j = -1;
                    foreach (var item in orderList1)
                    {
                        this.dataGridView1.Rows.Add();
                        j++;
                        StringBuilder result5 = new StringBuilder();
                        StringBuilder result6 = new StringBuilder();
                        item.Details.ForEach(detail => result5.Append(detail.getGoodName()));
                        item.Details.ForEach(detail => result6.Append(detail.getGoodId()));
                        this.dataGridView1.Rows[j].Cells[0].Value = item.Id;
                        this.dataGridView1.Rows[j].Cells[1].Value = item.Customer.Name;
                        this.dataGridView1.Rows[j].Cells[2].Value = result5.ToString();
                        this.dataGridView1.Rows[j].Cells[3].Value = result6.ToString();
                        this.dataGridView1.Rows[j].Cells[4].Value = item.CreateTime;
                        this.dataGridView1.Rows[j].Cells[5].Value = item.TotalPrice; 
                    }
                    break;
                default:
                    List<Order> orderList2 = orderService.QueryAll();
                    int k = -1;
                    foreach (var item in orderList2)
                    {
                        this.dataGridView1.Rows.Add();
                        k++;
                        StringBuilder result7 = new StringBuilder();
                        StringBuilder result8 = new StringBuilder();
                        item.Details.ForEach(detail => result7.Append(detail.getGoodName()));
                        item.Details.ForEach(detail => result8.Append(detail.getGoodId()));
                        this.dataGridView1.Rows[k].Cells[0].Value = item.Id;
                        this.dataGridView1.Rows[k].Cells[1].Value = item.Customer.Name;
                        this.dataGridView1.Rows[k].Cells[2].Value = result7.ToString();
                        this.dataGridView1.Rows[k].Cells[3].Value = result8.ToString();
                        this.dataGridView1.Rows[k].Cells[4].Value = item.CreateTime;
                        this.dataGridView1.Rows[k].Cells[5].Value = item.TotalPrice; 
                    }
                    break;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Dispose();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请在查询窗口输入（仅支持ID删除！！！）");
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = orderService.orders;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
