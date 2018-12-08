using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Administration_APP
{
    public partial class OrderForm : MetroFramework.Forms.MetroForm
    {
        
        private DataTable deldata;
        private Connection c;
        private DatabaseConnectionInterface dti;
        private LoginForm lf;
        private DataTable data;
        public OrderForm()
        {
            InitializeComponent();
            try{
            c = new Connection();
            dti = c.connect();
            data = dti.getToDataTable("SELECT orders.orderID, orders.buyer, orders.orderDate FROM orders, orderitems, warehouse WHERE warehouse.itemNumber=orderitems.itemID AND orders.orderID=orderitems.orderID AND orders.shipped=0 GROUP BY orders.orderDate");
            OrderGridView.DataSource = data;
            OrderGridView.Columns["orderID"].Visible = false;
            OrderGridView.Columns["orderDate"].Width = 270;
            OrderGridView.Columns["orderDate"].HeaderText = "Order Date";
            OrderGridView.Columns["buyer"].HeaderText = "Buyer Name";
            OrderGridView.Refresh();
            }
            catch(Exception ee)
            { }
        }

        private void mtLogout_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            lf = new LoginForm();
            lf.ShowDialog();
            dti.close();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        try{
            if (MessageBox.Show("Are you sure to delete this order?", "Delete Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Connection c = new Connection();
                dti = c.connect();

                int index = OrderGridView.SelectedRows[0].Index;
                string orderNumber = "SELECT orderID FROM orders WHERE orderID=\"" + OrderGridView[0, index].Value.ToString() + "\"";
                int orderID = int.Parse(dti.getOneField(orderNumber));
                string DeleteQuery = "DELETE FROM orders WHERE orderID=" + orderID;
                string Deletequery = "DELETE FROM orderitems WHERE orderID="+orderID;
                dti.executeDMQuery(DeleteQuery);
                dti.close();

                for (int i = 0; i < data.Rows.Count; i = i + 1)
                {
                    DataRow row = data.Rows[i];
                    if (int.Parse(row["orderID"].ToString()) == orderID)
                        data.Rows.Remove(row);
                }
                OrderGridView.Rows.RemoveAt(index);
                OrderGridView.Refresh();
            }
         }
         catch(Exception ee)
         { }
         }

        private void mtSend_Click(object sender, EventArgs e)
        {
        try{
            if(OrderGridView.SelectedRows.Count>0){
                if(MessageBox.Show("Are you sure to send out this order?", "Send Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Connection c = new Connection();
                    dti = c.connect();
                    int index = OrderGridView.SelectedRows[0].Index;
                    string orderNumber = "SELECT orderID FROM orders WHERE orderID=\"" + OrderGridView[0, index].Value.ToString() + "\"";
                    int orderID = int.Parse(dti.getOneField(orderNumber));
                    string sendQuery = "UPDATE orders SET shipped=1 WHERE orderID=\"" + OrderGridView[0, index].Value.ToString() + "\"";
                    dti.executeDMQuery(sendQuery);
                    for (int i = 0; i < data.Rows.Count; i = i + 1)
                    {
                        DataRow row = data.Rows[i];
                        if (int.Parse(row["orderID"].ToString()) == orderID)
                            data.Rows.Remove(row);
                    }
                    OrderGridView.DataSource = data;
                    OrderGridView.Refresh();
                }
            }
            }
            catch(Exception ee)
            {  }
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            data = dti.getToDataTable("SELECT orders.orderID, orders.buyer, orders.orderDate FROM orders, orderitems, warehouse WHERE warehouse.itemNumber=orderitems.itemID AND orders.orderID=orderitems.orderID AND orders.shipped=0 GROUP BY orders.orderDate");
            OrderGridView.DataSource = data;
            OrderGridView.Refresh();
        }
    }
}
