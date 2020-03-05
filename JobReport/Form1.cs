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
    public partial class JobReport : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = JOBREPORT; User ID = XMI_SUPPORT; Password = Passw0rd");
        public Login login;
        Export export = new Export();
        public JobReport(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void JobReport_Load(object sender, EventArgs e)
        {
            cmbShift.Items.Add("Shift 1");
            cmbShift.Items.Add("Shift 2");
            cmbShift.Items.Add("Shift 3");

            lblUser.Text = "Welcome : " + login.txtuser.Text;

            cn.Open();
            string query = "select Username from TblUser where usergroup = 'PIC'";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbReq.Items.Add(reader[0]);
            }
            reader.Close();
            cn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("SAVE REPORT?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                return;
            }
            else if (txtProblem.Text == string.Empty || txtSolution.Text == string.Empty)
            {
                MessageBox.Show("PROBLEM DAN SOLUTION TIDAK BOLEH DI KOSONGKAN !!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbShift.SelectedIndex == -1)
            {
                MessageBox.Show("KAMU SHIFT BERAPA !!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbReq.SelectedIndex == -1)
            {
                MessageBox.Show("PIC KAMU SIAPA !!!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cn.Open();
                string query = @"insert into TblReport (Shift,Problem,Solution,OtherJob,JobProgress,PIC,Date,CreatedBy,CreatedDate) values (@shift,@problem,@solution,@other,@progress,@request,@date,@user,@date)";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("shift", cmbShift.Text);
                cmd.Parameters.AddWithValue("problem", txtProblem.Text);
                cmd.Parameters.AddWithValue("solution", txtSolution.Text);
                cmd.Parameters.AddWithValue("other", txtOther.Text);
                cmd.Parameters.AddWithValue("progress", txtJob.Text);
                cmd.Parameters.AddWithValue("request", cmbReq.Text);
                cmd.Parameters.AddWithValue("user", login.txtuser.Text);
                cmd.Parameters.AddWithValue("date", DateTime.Now);
                SqlDataReader reader = cmd.ExecuteReader();
                cn.Close();
                DialogResult dialog = MessageBox.Show("Report Telah Tersimpan","INFORMATION",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (dialog == DialogResult.OK)
                {
                    reset();
                }

            }


        }

        void reset()
        {
            cmbReq.SelectedIndex = -1;
            txtProblem.Text = string.Empty;
            txtSolution.Text = string.Empty;
            txtOther.Text = string.Empty;
            txtJob.Text = string.Empty;
            cmbShift.SelectedIndex = -1;
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            export.ShowDialog();
        }
    }
}
