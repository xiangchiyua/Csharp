using MySql.Data.MySqlClient;
using OrderApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace homework6
{
    internal class MySqlOpHelper
    {
        private string conStr = null;
        private MySqlConnection msc = null;
        private MySqlCommand msco = null;
        private MySqlDataReader msdr = null;
        // 用于系统登录 存储用户名和密码
        public Dictionary<string, string> dics = null;
        // 用于数据库查询后的数据对象List<Order>
        public List<Order> stus = null;

        public MySqlOpHelper(string conStr)
        {
            this.conStr = conStr ?? throw new ArgumentNullException(nameof(conStr));
        }

        

        /// <summary>
        /// 数据库操作 增删改
        /// </summary>
        /// <param name="opStr"></param>
        public void OpAddDeleUpdateMySql(string opStr)
        {
            try
            {
                msc = new MySqlConnection(conStr);
                msco = new MySqlCommand(opStr, this.msc);
                msc.Open();
                msco.ExecuteNonQuery();
                MessageBox.Show("操作成功！", "数据库操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("操作失败！", "数据库操作", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                msco.Dispose();
                msc.Close();
            }
        }

        /// <summary>
        /// 数据库操作 查询
        /// </summary>
        /// <param name="queryStr"></param>
        public void OpQueryMySql(string queryStr)
        {
            try
            {
                msc = new MySqlConnection(conStr);
                msco = new MySqlCommand(queryStr, this.msc);
                msc.Open();
                msdr = msco.ExecuteReader();
                stus = new List<Order>();
                while (msdr.Read())
                {
                    DateTime dateTime = DateTime.Now;
                    Customer customer = new Customer(msdr[0].ToString(), msdr[1].ToString());
                    stus.Add(new Order(int.Parse(msdr[0].ToString()), customer,dateTime));
                }
                //foreach(var i in stus) {
                //    MessageBox.Show(i.ToString());
                //}
            }
            catch
            {
                MessageBox.Show("查询失败！", "数据库查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                msco.Dispose();
                msc.Close();
            }
        }
    }
}

