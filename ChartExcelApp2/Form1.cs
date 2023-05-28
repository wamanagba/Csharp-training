using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;
using RDotNet;




namespace ChartExcelApp
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            Loadrecords();
        }

        void fillChart()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT yield, gender FROM crop", con);
            da.Fill(dt);
            chart.DataSource = dt;
            con.Close();

            chart.Series["CropYield"].XValueMember = "gender";
            chart.Series["CropYield"].YValueMembers = "yield";
            chart.Titles.Add("Yield by Gender");
            con.Close();

        }




        public void EffacerDonnees()
        {
            string deleteQuery = "DELETE FROM crop"; 

                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand(deleteQuery, con);
                    command.ExecuteNonQuery();
                    DgrCrop.Rows.Clear();

                MessageBox.Show("The data has been successfully deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error was detected when deleting the data : " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
        }
        

        private void Download()
        {
            try
            {

                //Specifies the path to the R binary
                REngine.SetEnvironmentVariables("C:/Program Files/R/R-3.6.0/bin/i386", "C:/Program Files/R/R-3.6.0");
                
                // R session initialization 
                REngine engine = REngine.GetInstance();

                // Read R code from a file
                string scriptPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scripts.R");
                string script = File.ReadAllText(scriptPath);
                // Running the R code
                engine.Evaluate(script);

                MessageBox.Show("Download Succefully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }











        public void Loadrecords()
        {
            DgrCrop.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM crop", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                DgrCrop.Rows.Add(i, dr["ID"].ToString(), dr["year"].ToString(), dr["yield"].ToString(),
                    dr["region"].ToString(), dr["gender"].ToString(), dr["soil"].ToString(), dr["variety"].ToString(),
                    dr["ZAI"].ToString(), dr["weeding"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            DgrCrop.Rows.Clear();

            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFlieName;

            openFD.Filter = "Excel Office | *.xls; *.xlsx";
            openFD.ShowDialog();
            strFlieName = openFD.FileName;

            if(strFlieName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFlieName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;

                for(xlRow = 2; xlRow <=xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    DgrCrop.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text,
                        xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text,
                        xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text);
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < DgrCrop.Rows.Count; i++)
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO crop (ID, year, yield, region, gender, soil, variety, ZAI, weeding) VALUES (@ID, @year, @yield, @region, @gender, @soil, @variety, @ZAI, @weeding)", con);
                    cmd.Parameters.AddWithValue("@ID", DgrCrop.Rows[i].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@year", DgrCrop.Rows[i].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@yield", DgrCrop.Rows[i].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@region", DgrCrop.Rows[i].Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("@gender", DgrCrop.Rows[i].Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@soil", DgrCrop.Rows[i].Cells[6].Value.ToString());
                    cmd.Parameters.AddWithValue("@variety", DgrCrop.Rows[i].Cells[7].Value.ToString());
                    cmd.Parameters.AddWithValue("@ZAI", DgrCrop.Rows[i].Cells[8].Value.ToString());
                    cmd.Parameters.AddWithValue("@weeding", DgrCrop.Rows[i].Cells[9].Value.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                MessageBox.Show("RECORDS SUCCESSFULLY SAVED.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadrecords();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            
        }

        private void BtnPlot_Click(object sender, EventArgs e)
        {
            fillChart();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            EffacerDonnees();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            Download();
        }
    }
}
