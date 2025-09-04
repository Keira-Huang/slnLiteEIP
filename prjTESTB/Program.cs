using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjTESTB.View;

namespace prjTESTB
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin loginForm = new FrmLogin();

            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.Employee != null)
            {
                // 登入成功後開啟主畫面，並傳入登入員工資料
                Application.Run(new FrmMain(loginForm.Employee));
            }
            else
            {
                // 若登入失敗或關閉視窗則退出程式
                Application.Exit();

            }
        }
    }

}

