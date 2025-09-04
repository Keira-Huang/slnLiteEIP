using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjTEST1;
using prjTESTB.View;

namespace prjTESTB
{
    public partial class FrmMain : Form
    {


     

        private tEmployee _currentEmployee;

        private string marqueeText;  // 跑馬燈完整文字
        private int marqueeIndex = 0;
        private int visibleLength = 30;  // 可見的文字長度，可依照 lblWelcome 的寬度調整



        public FrmMain(tEmployee employee)
        {
            InitializeComponent();


            _currentEmployee = employee;


            marqueeText = $"     Hello, {_currentEmployee.fName} Have a nice day.           ";
            lblWelcome.Text = marqueeText.Substring(0, visibleLength);

            // 設定 Timer 事件
            timerMarquee.Tick += timerMarquee_Tick;
            timerMarquee.Interval = 200; // 控制速度（毫秒）
            timerMarquee.Start();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            FrmAttendanceRecord frm = new FrmAttendanceRecord(_currentEmployee);
            frm.ShowDialog();
        }





        private void but_empsystem_Click(object sender, EventArgs e)
        {
            FrmEmployeeList frmEmployeeList = new FrmEmployeeList(_currentEmployee);
            frmEmployeeList.ShowDialog();
        }
        

        private void but_clock_Click(object sender, EventArgs e)
        {
            FrmWorktime frmWorktime = new FrmWorktime(_currentEmployee);
            frmWorktime.ShowDialog();
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            // 若不足 visibleLength，就補空白
            string displayText;

            if (marqueeIndex + visibleLength <= marqueeText.Length)
            {
                displayText = marqueeText.Substring(marqueeIndex, visibleLength);
            }
            else
            {
                int part1Length = marqueeText.Length - marqueeIndex;
                string part1 = marqueeText.Substring(marqueeIndex, part1Length);
                string part2 = marqueeText.Substring(0, visibleLength - part1Length);
                displayText = part1 + part2;
            }

            lblWelcome.Text = displayText;

            marqueeIndex++;
            if (marqueeIndex >= marqueeText.Length)
            {
                marqueeIndex = 0;
            }
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要登出嗎？", "登出確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin loginForm = new FrmLogin();
                loginForm.ShowDialog();

                if (loginForm.IsLoginSuccess)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                // 這裡不要執行任何動作，直接結束事件即可
                return;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblLogout.Click += lblLogout_Click;
        }
    }

}

