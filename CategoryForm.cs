using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Shoprite_inventory_system
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\swiftgh\Documents\inventoryinventory.sql.mdf;Integrated Security=True;Connect Timeout=30");
        private void label_heading_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Category values('" + TextBox_catid.Text + "','" + TextBox_catname.Text + "','" + TextBox_des + "')");
                
            try
            {

            }
            catch
            { 
            
            }
        }
    }
} 
