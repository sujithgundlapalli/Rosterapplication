using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (openFileDialog_Source.ShowDialog() == DialogResult.OK)
                {
                    txtBrowseSourceSheet.Text = openFileDialog_Source.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not proceed. Error occured as:: \n" + ex.Message);
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            try
            {

                if (folderBrowserDialog_Destination.ShowDialog() == DialogResult.OK)
                {
                    txtBrowseDestinationSheet.Text = folderBrowserDialog_Destination.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not proceed. Error occured as:: \n" + ex.Message);
            }
        }

        private void btnGenerateCSV_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(txtBrowseDestinationSheet.Text) &&
                    !string.IsNullOrEmpty(txtBrowseSourceSheet.Text) &&
                    !string.IsNullOrEmpty(txtCSVFileName.Text) &&
                    !string.IsNullOrEmpty(txtSheetName.Text)
                    )
                {

                    #region Reading Excel File

                    ReadingExcelData excel = new ReadingExcelData();
                    DataTable dtexcelData = excel.ReadExcel(txtBrowseSourceSheet.Text, txtSheetName.Text);

                    //Logging.WriteInfoLog("Red Excel data successfully");

                    //dataGridView1.DataSource = dtexcelData;

                    #endregion Reading Excel File

                    #region Reading 'Shift' XML file

                    DataSet dsShiftXML = new DataSet();
                    dsShiftXML.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "Shift.xml");

                    //Logging.WriteInfoLog("Red shift XML data successfully");

                    if (dsShiftXML != null)
                    {

                    }

                    #endregion Reading 'Shift' XML file

                    string filePath = txtBrowseDestinationSheet.Text + "\\" + txtCSVFileName.Text + ".xlsx";
                    string delimiter = ",";

                    if (dtexcelData != null && dtexcelData.Rows.Count > 0 && dtexcelData.Columns.Count > 0)
                    {
                        string[][] output = new string[][]
                        {
                        new string[] { "MID(format:10XXXXX)", "Date(format:dd.MM.yyyy)", "TransportRequest", "Shift(Refer:shiftid-shiftperiod)", "Name" }
                        };

                        int length = output.GetLength(0);
                        StringBuilder sb = new StringBuilder();
                        for (int index = 0; index < length; index++)
                            sb.AppendLine(string.Join(delimiter, output[index]));

                        for (int rowsCount = 1; rowsCount <= dtexcelData.Rows.Count; rowsCount++)
                        {
                            //Logging.WriteInfoLog("Entered into the 1st loop");

                            //string strMID = dtexcelData.Rows[rowsCount]["MID"].ToString();
                            string strMID = dtexcelData.Rows[rowsCount].ItemArray[0].ToString();
                            string strEmpName = dtexcelData.Rows[rowsCount].ItemArray[1].ToString();

                            if (!string.IsNullOrWhiteSpace(dtexcelData.Rows[rowsCount][0].ToString()))
                            {
                                string[] onlyId = strMID.Split('M');
                                strMID = string.Empty;
                                strMID = onlyId[1].ToString();
                                //Logging.WriteInfoLog(strMID + " - " + strEmpName + " row started");
                            }

                            for (int columnsCount = 2; columnsCount < dtexcelData.Columns.Count; columnsCount++)
                            {
                                //Date column
                                string date = dtexcelData.Rows[0][columnsCount].ToString();
                                string transportRequest = string.Empty;
                                string strShiftTime = string.Empty;

                                //Logging.WriteInfoLog("Entered into the 2nd loop for MID - " + strMID + "@ Date Column - " + date);
                                // Transport request column
                                #region old code
                                //if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "OFF" ||
                                //    dtexcelData.Rows[rowsCount][columnsCount].ToString() == "CO" ||
                                //    dtexcelData.Rows[rowsCount][columnsCount].ToString() == "TRV" ||
                                //    dtexcelData.Rows[rowsCount][columnsCount].ToString() == "LEAVE" ||
                                //    dtexcelData.Rows[rowsCount][columnsCount].ToString() == "Training" ||
                                //    dtexcelData.Rows[rowsCount][columnsCount].ToString() == "GS")
                                //{
                                //    transportRequest = "NO";
                                //}
                                //else
                                //{
                                //    transportRequest = "YES";
                                //}
                                #endregion old code
                                //Shift time column
                                #region old code
                                //if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "RMS")
                                //{
                                //    strShiftTime = "MS15";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "RNS")
                                //{
                                //    strShiftTime = "MS08";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "RES")
                                //{
                                //    strShiftTime = "MS02";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "GS")
                                //{
                                //    strShiftTime = "MS05";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "Training")
                                //{
                                //    strShiftTime = "MS05";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "OFF")
                                //{
                                //    strShiftTime = "OFF";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "CO")
                                //{
                                //    strShiftTime = "COFF";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "HOLIDAY")
                                //{
                                //    strShiftTime = "HOLL";
                                //}
                                //else if (dtexcelData.Rows[rowsCount][columnsCount].ToString() == "LEAVE")
                                //{
                                //    strShiftTime = "LEAV";
                                //}
                                #endregion old code

                                if (!string.IsNullOrWhiteSpace(dtexcelData.Rows[rowsCount][columnsCount].ToString()))
                                {
                                    DataRow[] drShiftTime = dsShiftXML.Tables[0].Select("ShiftType='" + dtexcelData.Rows[rowsCount][columnsCount].ToString() + "'");

                                    if (drShiftTime != null && drShiftTime.Count() > 0)
                                    {
                                        strShiftTime = drShiftTime[0]["Code"].ToString();

                                        transportRequest = drShiftTime[0]["TransportRequest"].ToString();
                                    }

                                    sb.Append(strMID + ",");
                                    sb.Append(date + ",");
                                    sb.Append(transportRequest + ",");
                                    sb.Append(strShiftTime + ",");
                                    sb.Append(strEmpName + ",");
                                    sb.Append(Environment.NewLine);
                                }
                                else if (string.IsNullOrWhiteSpace(dtexcelData.Rows[rowsCount][columnsCount].ToString()))
                                {
                                    //Logging.WriteInfoLog("Breaking 2nd loop @ MID - " + strMID + " @ Date Column- " + date);
                                    break;
                                }

                                //sb.Append(Environment.NewLine);
                            }

                            //sb.Append(Environment.NewLine);

                            if (string.IsNullOrWhiteSpace(dtexcelData.Rows[rowsCount][0].ToString()))
                            {
                                //Logging.WriteInfoLog("Breaking 1st loop @ MID - " + strMID + " @ Row Count- " + rowsCount);
                                break;
                            }
                        }

                        //Logging.WriteInfoLog("Came out of the loop successfully");

                        File.WriteAllText(filePath, sb.ToString());

                        MessageBox.Show("Successfully created CSV file");
                    }
                }
                else
                {
                    MessageBox.Show("All fields are mandatory. Please check once and proceed again.");
                }
            }
            catch (Exception ex)
            {
                //Logging.WriteErrorLog(ex.StackTrace);

                MessageBox.Show("Can not proceed. Error occured as:: \n" + ex.Message);


            }
        }

        private void timeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShiftSettings shiftForm = new ShiftSettings();
                shiftForm.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void generateTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
