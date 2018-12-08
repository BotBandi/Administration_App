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

    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private DatabaseConnectionInterface dti;
        private Connection c;
        private Warehouse sf;
        private OrderForm of;

        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            
        }
        private void mtLogin_Click(object sender, EventArgs e)
        {
            c = new Connection();
            dti = c.connect(); 
            string query = "SELECT category.catName FROM category, employee WHERE employee.catID=category.catID AND employee.username=\""+UsernameText.Text+"\"";
            string query2 = "SELECT COUNT(category.catName) FROM category, employee WHERE employee.catID=category.catID AND employee.password=\"" + PasswordText.Text + "\"";
            string result=dti.getOneField(query);
            int  result2 = int.Parse(dti.executeScalarQuery(query2));
            if (dti.isConnectionExsist())
            {
               
                if (result=="storage_manager" && result2==1)
                {
                    this.Hide();
                    sf = new Warehouse();
                    sf.ShowDialog();
                }
                else if(result=="order_manager" && result2 == 1)
                {
                    of = new OrderForm();
                    this.Hide();
                    of.ShowDialog();
                }
                else
                {
                    errorLabel.Visible = true;
                   
                }
            }
            else
            {
                MessageBox.Show("No Connection");
            }
            

            
        }
    }
}
