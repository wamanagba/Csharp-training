using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ImportExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadExcel_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd =new OpenFileDialog())
            {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Chose the file";
                if (ofd.ShowDialog() == DialogResult.OK)
                    FileName_LBL.Text = ofd.FileName;
            }
        }
        private void HardWayToLoad()
        {
            Microsoft.Office.Interop.Excel.Application xlapp;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
            Microsoft.Office.Interop.Excel.Range xlrange;

            try
            {
                xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(FileName_LBL.Text);
                xlworksheet = xlworkbook.Worksheets["Sheet1"];
                xlrange = xlworksheet.UsedRange;

                Data_GRD.ColumnCount = xlrange.Columns.Count;
                int i = 0;
                for (int xlrow = 1; xlrow <= xlrange.Rows.Count; xlrow++)
                {
                    Data_GRD.Rows.Add(i, xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text,
                        xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text, xlrange.Cells[xlrow, 7].Text,
                        xlrange.Cells[xlrow, 8].Text, xlrange.Cells[xlrow, 9].Text);
                }
                xlworkbook.Close();
                xlapp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EasyWayToLoad()
        {
            try
            {
                string conStr = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = '" + FileName_LBL.Text + "' ; Extended Properties" +
                    "= 'Excel 12.0; HDR = YES';";
                string olcmd = "SELECT * FROM [Sheet1$]";
                OleDbConnection conn = new OleDbConnection(conStr);
                OleDbDataAdapter Oldap = new OleDbDataAdapter(olcmd, conn);
                DataSet ds = new DataSet();
                Oldap.Fill(ds);
                Data_GRD.DataSource = ds.Tables[0];
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            EasyWayToLoad();
        }
    }
}
