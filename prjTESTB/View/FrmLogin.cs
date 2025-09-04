using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTESTB.View
{
    public partial class FrmLogin : Form
    {


        public bool IsLoginSuccess { get; private set; } = false;



        public tEmployee Employee { get; private set; }


        private bool _isClosed = true;
        private int _count = 0;
        private Timer _lockTimer = new Timer();
        private int _lockTimeRemaining = 10;


        public FrmLogin()
        {
            InitializeComponent();
        }



        private void but_logok_Click(object sender, EventArgs e)
        {

            if (!fbAccount.Enabled || !fbPassword.Enabled)
            {
                MessageBox.Show("請等待鎖定時間結束後再試");
                return;
            }




            string empId = fbAccount.fieldValue.Trim();
            string password = fbPassword.fieldValue.Trim();


            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("帳號與密碼皆為必填欄位，請重新輸入。");
                return;
            }


            using (dbBaseEntities db = new dbBaseEntities())
            {
                var user = db.tEmployee.FirstOrDefault(u => u.fEmployeeId == empId && u.fPassword == password);

                if (user != null)
                {
                    //LoggedInEmployee = user;
                    Employee = user;
                    MessageBox.Show("登入成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                    return; // <== 關鍵：成功後直接 return，避免再執行後面的提示
                }
                else
                {

                    _count++;

                    lblMessage.Text = "帳號或密碼錯誤。";
                    lblMessage.ForeColor = Color.Red;
                
                if (_count >= 3)
                {
                    LockLogin(); // 錯誤達 3 次就鎖定
                    return;
                }

                
                    MessageBox.Show("帳號與密碼不符，尚餘 " + (3 - _count).ToString() + " 次");
                }
            }
        }

        private void LockLogin()
        {
            fbAccount.Enabled = false;
            fbPassword.Enabled = false;
            but_logok.Enabled = false;

            lblMessage.Text = $"已超過錯誤次數，請等待 {_lockTimeRemaining} 秒後再嘗試登入。";
            lblMessage.ForeColor = Color.DarkOrange;

            _lockTimeRemaining = 10;
            _lockTimer.Interval = 1000;
            _lockTimer.Tick += LockTimer_Tick;
            _lockTimer.Start();
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            _lockTimeRemaining--;

            lblMessage.Text = $"請等待 {_lockTimeRemaining} 秒後再登入...";
            lblMessage.ForeColor = Color.DarkOrange;

            if (_lockTimeRemaining <= 0)
            {
                _lockTimer.Stop();
                _lockTimer.Tick -= LockTimer_Tick;

                fbAccount.Enabled = true;
                fbPassword.Enabled = true;
                but_logok.Enabled = true;
                lblMessage.Text = "";
                _count = 0;
            }
        }




        private void but_lognok_Click(object sender, EventArgs e)
        {
            _isClosed = false;
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            fbPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmForgotPassword forgotForm = new FrmForgotPassword();
            forgotForm.ShowDialog();  // 以對話框方式開啟，等使用者關閉後才回到原畫面
        }

      
    }


    }
    

