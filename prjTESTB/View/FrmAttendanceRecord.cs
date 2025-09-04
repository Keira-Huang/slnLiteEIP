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

namespace prjTESTB.View
{
    public partial class FrmAttendanceRecord : Form
    {

        private tEmployee _currentEmployee;

        public FrmAttendanceRecord(tEmployee currentEmployee)
        {
            InitializeComponent();
            _currentEmployee = currentEmployee;
        }



        private void FrmAttendanceRecord_Load(object sender, EventArgs e)
        {
            LoadAttendanceRecords(); // 預設載入
        }

        private void LoadAttendanceRecords()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            using (var db = new dbBaseEntities())
            {
                var records = db.AttendanceRecords
                    .Where(r => r.fEmployeeId == _currentEmployee.fEmployeeId &&
                                r.fPunchTime >= startDate &&
                                r.fPunchTime <= endDate)
                    .OrderByDescending(r => r.fPunchTime)
                    .Select(r => new
                    {
                        r.fEmployeeId,
                        r.fPunchTime,
                        r.fPunchType,
                        //r.Location
                    })
                    .ToList();

                dataGridView1.DataSource = records;


            }

            resetGridStyle();
        }
        private void but_SEARCH_Click(object sender, EventArgs e)
        {
            LoadAttendanceRecords(); // 點查詢時也呼叫同一個方法
        }

        private void but_ExportCSV_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("沒有資料可匯出！");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV 檔 (*.csv)|*.csv",
                FileName = "打卡記錄.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                {
                    // 標題列
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // 資料列
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString());
                            if (i < dataGridView1.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("匯出完成！");
            }
        }
    

        private void resetGridStyle()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 35;
            }

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
        }

    }
}

