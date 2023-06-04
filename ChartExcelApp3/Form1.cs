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
            SqlDataAdapter da = new SqlDataAdapter("SELECT year, temperature FROM crop", con);
            da.Fill(dt);
            chart.DataSource = dt;
            con.Close();

            chart.Series["CropYield"].XValueMember = "year";
            chart.Series["CropYield"].YValueMembers = "temperature";
            chart.Titles.Add("Mean temperature");
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
                DgrCrop.Rows.Add(i, dr["ID"].ToString(), dr["year"].ToString(), dr["temperature"].ToString());
            }
            dr.Close();
            con.Close();
        }

        public void Import()
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

            if (strFlieName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFlieName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet 1"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;

                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    DgrCrop.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text);
                }
                xlWorkbook.Close();
                xlApp.Quit();

            }
        }
        public void Save()
        {
            for (int i = 0; i < DgrCrop.Rows.Count; i++)
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO crop (ID, year, temperature) VALUES (@ID, @year, @temperature)", con);
                cmd.Parameters.AddWithValue("@ID", DgrCrop.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@year", DgrCrop.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@temperature", DgrCrop.Rows[i].Cells[3].Value.ToString());
                cmd.ExecuteNonQuery();
                con.Close();

            }
            MessageBox.Show("RECORDS SUCCESSFULLY SAVED.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loadrecords();
        }
        private void BtnImport_Click(object sender, EventArgs e)
        {
            EffacerDonnees();
            Import();
            Save();
            fillChart();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
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
