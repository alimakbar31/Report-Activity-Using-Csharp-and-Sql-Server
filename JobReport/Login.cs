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

namespace JobReport
{
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = JOBREPORT; User ID = XMI_SUPPORT; Password = Passw0rd");
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = " select * from TblUser where username ='" + txtuser.Text + "' and password='" + txtpswrd.Text + "'";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                JobReport jr = new JobReport(this);
                this.Hide();
                txtpswrd.Text = string.Empty;
                jr.Show();
            }
            else
            {
                MessageBox.Show("Username dan Password not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpswrd.Text = "";
                txtuser.Text = "";
                txtpswrd.Focus();
            }
            cn.Close();
        }

        private void txtpswrd_OnValueChanged(object sender, EventArgs e)
        {
            txtpswrd.isPassword = true;
        }

        private void txtpswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
