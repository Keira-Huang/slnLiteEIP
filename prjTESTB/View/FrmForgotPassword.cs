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
    public partial class FrmForgotPassword : Form
    {
        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private void but_Submit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("請輸入 Email");
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("請輸入新密碼");
                return;
            }

            using (dbBaseEntities db = new dbBaseEntities())
            {
                var user = db.tEmployee.FirstOrDefault(u => u.fEmail == email);
                if (user != null)
                {
                    user.fPassword = newPassword; 
                    db.SaveChanges();

                    MessageBox.Show("密碼已重設，請重新登入。");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("查無此 Email，請確認輸入。");
                }
            }
        }
    }
}

