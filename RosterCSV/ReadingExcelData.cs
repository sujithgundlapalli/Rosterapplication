using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterCSV
{
    public class ReadingExcelData
    {
        public DataTable ReadExcel(string filePath, string strSheetName)
        {
            DataTable data = new DataTable();



            try
            {
                #region if excel is of "97-2003 Worksheet (.xls)" version                

                FileInfo f = new FileInfo(filePath);
                if (f.Extension != ".xlsx")
                {
#pragma warning disable CS0162 // Unreachable code detected
                    //excelIssue.Add(1, "Only MS excel file allowed with extension " + ".xls" + "");
#pragma warning restore CS0162 // Unreachable code detected                                        
                    data = null;
                    MessageBox.Show("Selected excel file should be of '97-2003 Worksheet(.xls)' format");
                    return data;
                }

                var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", filePath);
                // Preview_FullPass
                StringBuilder strSheet = new StringBuilder();
                strSheet.Append('[');
                strSheet.Append(strSheetName);
                strSheet.Append("$");
                strSheet.Append(']');

                var adapter = new OleDbDataAdapter("SELECT * FROM " + strSheet + "", connectionString);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "excelData");

                data = ds.Tables["excelData"];

                

                return data;

                #endregion if excel is of "97-2003 Worksheet (.xls)" version

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return data;
        }
    }
}
