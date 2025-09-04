using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjTEST1;

namespace prjTESTB.View
{
    public partial class FrmWorktime : Form
    {

        private tEmployee _employee;
        public FrmWorktime(tEmployee currentEmployee)
        {
            InitializeComponent();
            _employee = currentEmployee;


            lab_EmpName.Text = _employee.fName; // 顯示員工姓名
            //comboPunchType.Items.Add("上班");
            //comboPunchType.Items.Add("下班");
            comboPunchType.SelectedIndex = 0;

        }


        private void FrmWorktime_Load(object sender, EventArgs e)
        {
            timerClock.Start(); // 啟動定時器
            lab_datetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); // 立即顯示一次
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lab_datetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }



        private void but_btnPunch_Click(object sender, EventArgs e)
        {

            if (comboPunchType.SelectedItem == null)
            {
                MessageBox.Show("請選擇打卡類型");
                return;
            }

            string punchType = comboPunchType.SelectedItem.ToString();
            DateTime punchTime = DateTime.Now;
            string employeeId = _employee.fEmployeeId; // ✅ 使用登入者 ID
                                                       //string location = txtLocation.Text.Trim();

            using (dbBaseEntities db = new dbBaseEntities())
            {
                var record = new AttendanceRecords
                {
                    fEmployeeId = employeeId,
                    fPunchTime = punchTime,
                    fPunchType = punchType,
                    //Location = location
                };

                // 6. 把這筆物件加入到 DbContext
                db.AttendanceRecords.Add(record);
                // 7. 寫入資料庫
                db.SaveChanges();

            }

            lab_punchtime.Text = $"{punchTime:HH:mm:ss}";




            MessageBox.Show($"打卡成功！\nID：{employeeId}\n類型：{punchType}\n時間：{punchTime:yyyy/MM/dd HH:mm:ss}",
                "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);

          
        }

        private void but_RecordList_Click(object sender, EventArgs e)
        {
            FrmAttendanceRecord AttRecord = new FrmAttendanceRecord(_employee);
            AttRecord.ShowDialog();



        }
    }
}











