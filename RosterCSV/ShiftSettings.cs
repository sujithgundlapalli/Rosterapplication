using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosterCSV
{
    public partial class ShiftSettings : Form
    {
        public ShiftSettings()
        {
            InitializeComponent();
        }

        private void ShiftSettings_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet dsShift = new DataSet("RosterPlan");
                dsShift.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "Shift.xml");

                grdvShifts.DataSource = dsShift.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured as : \n" + ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtShift = new DataTable();
                dtShift.TableName = "RosterPlan";

                foreach (DataGridViewColumn col in grdvShifts.Columns)
                {
                    dtShift.Columns.Add(col.HeaderText);
                }

                foreach (DataGridViewRow row in grdvShifts.Rows)
                {
                    DataRow dRow = dtShift.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dtShift.Rows.Add(dRow);
                }

                dtShift.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "Shift.xml");

                MessageBox.Show("Successfully updated shift settings.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured as : \n:" + ex.Message);
            }
        }
    }
}
