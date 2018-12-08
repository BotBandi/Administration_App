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
using MetroFramework.Forms;
namespace Administration_APP
{
    public partial class Warehouse : MetroFramework.Forms.MetroForm
    {

        private bool deletemode;
        private DataTable deldata;
        private DataTable data;
        private Connection c;
        private DatabaseConnectionInterface dti;
        private AddEditForm aef;
        private LoginForm lf;

      
        public Warehouse()
        {
            InitializeComponent();
            c = new Connection();
            dti = c.connect();
            deletemode = false;
            data = dti.getToDataTable("SELECT * FROM warehouse");
            deldata = dti.getToDataTable("SELECT itemName, itemPrice, itemQuantity FROM warehouse WHERE itemNumber NOT IN (SELECT DISTINCT itemID FROM orderitems)");
            StorageGridView.DataSource = data;
            StorageGridView.Columns["itemNumber"].Visible = false;
            StorageGridView.Columns["itemPic"].Visible = false;
            StorageGridView.Columns["itemName"].Width = 297;
            StorageGridView.Columns["itemName"].HeaderText = "Item Name";
            StorageGridView.Columns["itemPrice"].HeaderText = "Item Price";
            StorageGridView.Columns["itemQuantity"].HeaderText = "Quantity";
            
        }
       
        private void StorageForm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void MtAdd_Click(object sender, EventArgs e)
        {
            aef = new AddEditForm();
            aef.setFormText("Add New Item");
            
            try{
                if(aef.ShowDialog()==DialogResult.OK)
                {
                    Connection c = new Connection();
                    DatabaseConnectionInterface dcf = c.connect();
                    string MaxQuery = "SELECT MAX(itemNumber) FROM warehouse";
                    int newItem = int.Parse(dcf.executeScalarQuery(MaxQuery)) + 1;

                    string InsertQuery = "INSERT INTO warehouse(itemNumber,itemName,itemPrice,itemQuantity,itemPic) VALUES("+newItem+",\""+aef.getItemName()+"\","+aef.getItemPrice()+","+aef.getItemQuantity()+",\""+aef.getItempic()+"\")";
                    dcf.executeDMQuery(InsertQuery);
                    dcf.close();
                    data.Rows.Add(newItem, aef.getItemName(), aef.getItemPrice(), aef.getItemQuantity(), aef.getItempic());
                    data = dti.getToDataTable("SELECT * FROM warehouse");
                    deldata = dti.getToDataTable("SELECT itemName, itemPrice, itemQuantity FROM warehouse WHERE itemNumber NOT IN (SELECT DISTINCT itemID FROM orderitems)");
                    StorageGridView.DataSource = data;
                    StorageGridView.Refresh();
                }
                aef.Hide();
            }
            catch(Exception ee)
            {
                return;
            }
        }

        private void mtRefresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            StorageGridView.Refresh();
        }

        private void MtModify_Click(object sender, EventArgs e)
        {
            try
            {
                aef = new AddEditForm();
            aef.setFormText("Modify Item");
            foreach (DataGridViewRow row in StorageGridView.SelectedRows)
            {
                aef.setItemname(row.Cells[1].Value.ToString().TrimEnd());
                aef.setItemPrice(row.Cells[2].Value.ToString().TrimEnd());
                aef.setItemQuantity(row.Cells[3].Value.ToString().TrimEnd());
                aef.setItemPicture(row.Cells[4].Value.ToString().TrimEnd());
            }
                aef.ShowDialog();
            
            if (aef.DialogResult == DialogResult.OK)
            {
                Connection c = new Connection();
                DatabaseConnectionInterface dci = c.connect();
                string getitemID = "SELECT itemNumber FROM warehouse WHERE itemName=\""+aef.getItemName()+"\"";
                int itemID = int.Parse(dci.getOneField(getitemID));
                string UpdateItem = "UPDATE warehouse SET itemName=\"" + aef.getItemName() + "\", itemPrice=\"" + aef.getItemPrice() + "\", itemQuantity=\"" + aef.getItemQuantity() + "\", itemPic=\""+aef.getItempic()+"\" WHERE itemNumber=" + itemID;
                dci.executeDMQuery(UpdateItem);
                dci.close();

                DataRow[] row = data.Select("itemNumber="+itemID);
                row[0]["itemName"] = aef.getItemName();
                row[0]["itemPrice"] = aef.getItemPrice();
                row[0]["itemQuantity"] = aef.getItemQuantity();
                row[0]["itemPic"] = aef.getItempic();
                StorageGridView.Refresh();
            }
            }
            catch(Exception ee)
            { MessageBox.Show("Please select a row to modify!"); }
        }
        private void mtDel_Click(object sender, EventArgs e)
        {
        try{
            if(deletemode==false)
            {
                deletemode = true;
                StorageGridView.DataSource = deldata;
                StorageGridView.Columns["itemName"].Width = 297;
                StorageGridView.Refresh();
                mtDelete.Text = "Back";
            }
            else{
                deletemode = false;
                StorageGridView.DataSource = data;
                StorageGridView.Columns["itemNumber"].Visible = false;
                StorageGridView.Columns["itemPic"].Visible = false;
                StorageGridView.Columns["itemName"].Width = 297;
                StorageGridView.Columns["itemName"].HeaderText = "Item Name";
                StorageGridView.Columns["itemPrice"].HeaderText = "Item Price";
                StorageGridView.Columns["itemQuantity"].HeaderText = "Quantity";
                StorageGridView.Refresh();
                mtDelete.Text = "Delete";
            }
            }
            catch(Exception ee)
            { }
        }
        private void mtLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            lf = new LoginForm();
            lf.Show();
        }

        private void StorageGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        try{
            if(!deletemode)
            {
                return;
            }
            if (StorageGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure to delete this item?", "Delete Item", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    Connection c = new Connection();
                    dti = c.connect();
                
                    int index = StorageGridView.SelectedRows[0].Index;
                    string itemNumber = "SELECT itemNumber FROM warehouse WHERE itemName=\"" +StorageGridView[0,index].Value.ToString() +"\"";
                    int itemID = int.Parse(dti.getOneField(itemNumber));
                    string DeleteQuery = "DELETE FROM warehouse WHERE itemNumber=" + itemID;
                    dti.executeDMQuery(DeleteQuery);
                    dti.close();

                    for (int i = 0; i < data.Rows.Count; i = i + 1)
                    {
                        DataRow row = data.Rows[i];
                        if (int.Parse(row["itemNumber"].ToString()) == itemID)
                            data.Rows.Remove(row);
                    }
                        StorageGridView.Rows.RemoveAt(index);
                    StorageGridView.Refresh();
                }
            }
               
        }
        catch(Exception ee)
        {

        }
        }

        private void StorageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
