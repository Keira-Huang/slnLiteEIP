using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTESTB.View
{
    public partial class FrmEmployeeEditor : Form
    {

        private bool _isOk;
        public bool isOk
        {
            get { return _isOk; }
            set { _isOk = value; }
        }


        public FrmEmployeeEditor()
        {
            InitializeComponent();
        }

        private tEmployee _Employee;


        public tEmployee Employee
        {
            get
            {
                if (_Employee == null)
                    _Employee = new tEmployee();
                _Employee.fId = Convert.ToInt32(fb_fId.fieldValue);
                _Employee.fEmployeeId = fb_EmpId.fieldValue;
                _Employee.fName = fb_Name.fieldValue;
                _Employee.fEmail = fb_Email.fieldValue;
                _Employee.fTitle = fb_Title.fieldValue;
                _Employee.fPassword = fb_Pwd.fieldValue;


                return _Employee;
            }
            set
            {
                _Employee = value;
                fb_fId.fieldValue = _Employee.fId.ToString();
                fb_EmpId.fieldValue = _Employee.fEmployeeId.ToString();
                fb_Name.fieldValue = _Employee.fName;
                fb_Email.fieldValue = _Employee.fEmail;
                fb_Title.fieldValue = _Employee.fTitle;
                fb_Pwd.fieldValue = _Employee.fPassword;

                if (_Employee.fImage == null)
                    return;
                try
                {
                    Stream imgstream = new MemoryStream(_Employee.fImage);
                    pictureBox1.Image = Bitmap.FromStream(imgstream);

                }
                catch { }

            }
        }

        //照片
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FileDialog.Filter = "員工照片|*.jpg;*.png";
            if (FileDialog.ShowDialog() != DialogResult.OK)
                return;
            Image image = Bitmap.FromFile(FileDialog.FileName);
            pictureBox1.Image = image;

            FileStream stream = new FileStream(FileDialog.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            if (_Employee == null)
                _Employee = new tEmployee();
            _Employee.fImage = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();
        }

        private void but_confirm_Click(object sender, EventArgs e)
        {
            if (!isValidated())
                return;

            else
            {
                _isOk = true;
                Close();
            }
        }
        private bool isValidated()
        {
            string s = "";

            string empId = fb_EmpId.fieldValue?.Trim();
            string name = fb_Name.fieldValue?.Trim();
            string Email = fb_Email.fieldValue?.Trim();
            string pwd = fb_Pwd.fieldValue?.Trim();

            if (string.IsNullOrEmpty(empId))
                s += "\r\n員工編號是必填欄位";

            if (string.IsNullOrEmpty(name))
                s += "\r\n姓名是必填欄位";

            if (string.IsNullOrEmpty(Email))
                s += "\r\n郵件是必填欄位";

            if (string.IsNullOrEmpty(pwd))
                s += "\r\n密碼是必填欄位";

            else if (pwd.Length < 3)
                s += "\r\n密碼長度不可少於 3 個字元";

            using (var db = new dbBaseEntities())
            {
                string fldValue = fb_EmpId.fieldValue;
                string emp_Id = fldValue;
                int editingId = Employee?.fId ?? 0;

                bool isDuplicate = db.tEmployee.Any(emp =>
                    emp.fEmployeeId == emp_Id && emp.fId != editingId);

                if (isDuplicate)
                    s += "\r\n員工編號已存在，請重新輸入";
            }

            if (!string.IsNullOrEmpty(s))
            {
                MessageBox.Show(s, "資料驗證錯誤");
                return false;
            }

            return true;
           
        }


        private void ResetFields()
        {
            fb_EmpId.fieldValue = "";
            fb_Name.fieldValue = "";
            fb_Email.fieldValue = "";
            fb_Title.fieldValue = "";
            fb_Pwd.fieldValue = "";

        }



        private void butt_cancel_Click(object sender, EventArgs e)
        {
            ResetFields();
            Close();
        }
    }
}


