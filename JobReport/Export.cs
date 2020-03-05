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
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace JobReport
{
    public partial class Export : Form
    {
        SqlConnection cn = new SqlConnection("Data Source = 192.168.9.250; Initial Catalog = JOBREPORT; User ID = XMI_SUPPORT; Password = Passw0rd");
        public Export()
        {
            InitializeComponent();
        }

        public void Export_Load(object sender, EventArgs e)
        {
            cn.Open();
            string query = "select Username from TblUser where usergroup = 'TECH'";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbtech.Items.Add(reader[0]);
            }
            reader.Close();
            cn.Close();
            
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cn.Open();
            string query = "select Shift,Problem,Solution,OtherJob,JobProgress,PIC,CreatedBy,CreatedDate from TblReport where CreatedBy = '" + cmbtech.SelectedItem + "' and Date between '" + from.Value.ToString("yyyy-MM-dd") + "' and '"+to.Value.ToString("yyyy-MM-dd")+"'";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Range["B2:E31"].HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify;
                xlWorkSheet.Range["A1:A31"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["F1:H31"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["B1:E1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A1:H1"].Font.Bold = true;
                xlWorkSheet.Range["A2:H31"].Font.Size = 11;
                xlWorkSheet.Range["B1:E1"].ColumnWidth = 32;
                xlWorkSheet.Range["F1:H1"].ColumnWidth = 15;
                xlWorkSheet.Range["A1:H31"].WrapText = true;
                xlWorkSheet.Range["A1:H1"].Interior.Color = Color.Orange;
                xlWorkSheet.Range["A2:H31"].Interior.Color = Color.LightGray;
                xlWorkSheet.Range["A1:H31"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    xlWorkSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 0; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.InitialDirectory = @"C:\Users\User\Desktop";
                saveDlg.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDlg.FilterIndex = 0;
                saveDlg.RestoreDirectory = true;
                saveDlg.Title = "Save As";

                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                   
                    string path = saveDlg.FileName;
                    xlWorkBook.SaveCopyAs(path);
                    xlWorkBook.Saved = true;
                    

                    DialogResult dr = MessageBox.Show("Data Sudah Di Simpan, Apakah anda ingin membukanya?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        xlApp.Visible = true;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Install Microsoft Office atau WPS Office","EROR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
