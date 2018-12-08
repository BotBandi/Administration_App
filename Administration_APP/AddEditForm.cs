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
    public partial class AddEditForm : MetroFramework.Forms.MetroForm
    {

        public AddEditForm()
        {
            InitializeComponent();
        }
        public void setFormText(string text)
        {
            this.Text = text;
        }
        public string getItemPrice()
        {
            return textBox2.Text;
        }
        public string getItemQuantity()
        {
            return textBox3.Text;
        }
        public void setItemname(string iname)
        {
            textBox4.Text = iname;
        }
        public void setItemPrice(string iprice)
        {
            textBox2.Text = iprice;
        }
        public string getItemName()
        {
            return textBox4.Text;
        }
        public void setItemQuantity(string iqua)
        {
            textBox3.Text = iqua;
        }
        public void setItemPicture(string itempic)
        {
            textBox1.Text = itempic;
        }
        public string getItempic()
        {
            return textBox1.Text;
        }
        private void AddEditForm_Load(object sender, EventArgs e)
        {
                
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
