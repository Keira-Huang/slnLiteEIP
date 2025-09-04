using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjTESTB;
using prjTESTB.View;

namespace prjTEST1
{
    public partial class FrmEmployeeList : Form
    {


        SqlDataAdapter _adapter = null;
        SqlCommandBuilder _builder = null;
        private int _position = -1;
        private List<tEmployee> _listEmployee = null;
        private tEmployee _currentEmployee;


        public FrmEmployeeList(tEmployee loginEmployee)
        {
            InitializeComponent();
            _currentEmployee = loginEmployee;

        }

   

        private void resetGridStyle()
        {
            int[] widths = { 80, 150, 200, 100, 200, 200, 70 }; // 可自行調整或擴充
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i < widths.Length)
                    dataGridView1.Columns[i].Width = widths[i];
                else
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 35;
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                isColorChanged = !isColorChanged;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(237, 237, 237);
            }
        }



        private void but_empsystem_Click(object sender, EventArgs e)
        {
            FrmEmployeeList frmEmployeeList = new FrmEmployeeList(_currentEmployee);
            frmEmployeeList.ShowDialog();
        }



        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            if (_currentEmployee == null)
            {
                MessageBox.Show("未提供登入資訊，將關閉表單。");
                this.Close();
                return;
            }


            this.Text = $"員工資料（登入者：{_currentEmployee.fName}, 職稱：{_currentEmployee.fTitle}）";

            // 權限控制
            string title = _currentEmployee?.fTitle?.Trim();
            if (string.IsNullOrEmpty(title) || title != "Manager")
            {
                But_Create.Enabled = false;
                But_Delete.Enabled = false;
                But_Update.Enabled = false;
                dataGridView1.ReadOnly = true;
            }
            ReFreshData();
        }

        private void But_Refresh_Click(object sender, EventArgs e)
        {
            ReFreshData();
           
        }

        private void ReFreshData()
        {
            dbBaseEntities db = new dbBaseEntities();
            var data = from p in db.tEmployee
                       orderby p.fEmployeeId
                       select p;

            _listEmployee = data.ToList();

            //var datashow = from p in _listEmployee
            //               select new
            //               {
            //                   員工編號 = p.fEmployeeId,
            //                   員工姓名 = p.fName,
            //                   電子郵件 = p.fEmail,
            //                   職稱 = p.fTitle

            //               };
            if (_currentEmployee?.fTitle?.Trim() == "Manager")
            {
                var datashow = from p in _listEmployee
                               select new
                               {
                                   員工編號 = p.fEmployeeId,
                                   員工姓名 = p.fName,
                                   電子郵件 = p.fEmail,
                                   職稱 = p.fTitle,
                                   密碼 = p.fPassword
                               };
                dataGridView1.DataSource = datashow.ToList();
                resetGridStyle();
            }
            else
            {
                var datashow = from p in _listEmployee
                               select new
                               {
                                   員工編號 = p.fEmployeeId,
                                   員工姓名 = p.fName,
                                   電子郵件 = p.fEmail,
                                   職稱 = p.fTitle
                               };
                dataGridView1.DataSource = datashow.ToList();
                resetGridStyle();
            }


        
        }

        private void But_Create_Click(object sender, EventArgs e)
        {
            FrmEmployeeEditor frmEmployeeEditor = new FrmEmployeeEditor();
            frmEmployeeEditor.ShowDialog();

            tEmployee employee = frmEmployeeEditor.Employee;
            dbBaseEntities db = new dbBaseEntities();
            db.tEmployee.Add(employee);
            db.SaveChanges();


            if (!frmEmployeeEditor.isOk)
                return;
            //createEmployee(editor.employee);
            ReFreshData();
            MessageBox.Show("新增資料完成");



        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }


        private void But_Delete_Click(object sender, EventArgs e)
        {
            dbBaseEntities db = new dbBaseEntities();
            if (_position < 0 || _position >= _listEmployee.Count)
                return;
            tEmployee del = _listEmployee[_position];
            tEmployee dele = db.tEmployee.FirstOrDefault(p => p.fId == del.fId);
            
            if (dele == null)
            {
                MessageBox.Show("查無資料");
                return;
            }
            else
            {
                db.tEmployee.Remove(dele);
                db.SaveChanges();
                ReFreshData();
            }

        }

        private void But_Update_Click(object sender, EventArgs e)
        {
        
            editEmployee();

        }

        private void editEmployee()
        {
            dbBaseEntities db = new dbBaseEntities();
            if (_position < 0 || _position >= _listEmployee.Count)
                return;
            
            FrmEmployeeEditor frmEmployeeEditor = new FrmEmployeeEditor();
            frmEmployeeEditor.Employee = _listEmployee[_position];
            frmEmployeeEditor.ShowDialog();
          
           
            if (!frmEmployeeEditor.isOk)
                return;

            tEmployee update = db.tEmployee.FirstOrDefault(p => p.fId == frmEmployeeEditor.Employee.fId);
            if (update == null)
            {
                return;
            }


            update.fEmployeeId = frmEmployeeEditor.Employee.fEmployeeId;
            update.fName = frmEmployeeEditor.Employee.fName;
            update.fEmail = frmEmployeeEditor.Employee.fEmail;
            update.fTitle = frmEmployeeEditor.Employee.fTitle;
            update.fPassword = frmEmployeeEditor.Employee.fPassword;


            if (frmEmployeeEditor.Employee.fImage != null)
                update.fImage = frmEmployeeEditor.Employee.fImage;

            db.SaveChanges();
            ReFreshData();

            MessageBox.Show("更新完成");
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string title = _currentEmployee?.fTitle?.Trim();

            if (!string.IsNullOrEmpty(title) && title == "Manager")
            {
                editEmployee();
            }
            else
            {
                MessageBox.Show("您沒有權限修改資料。", "權限不足", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            queryByKeyword();
        }

        private void queryByKeyword()
        {
            dbBaseEntities db = new dbBaseEntities();

            var datas = from p in db.tEmployee
                        where p.fName.Contains(txtKeyword.Text)
                                          //|| p.fPhone.Contains(txtKeyword.Text)
                                          || p.fTitle.Contains(txtKeyword.Text)
                                          || p.fEmail.Contains(txtKeyword.Text)
                                          || p.fEmployeeId.Contains(txtKeyword.Text)
                        select p;
            _listEmployee = datas.ToList();
            dataGridView1.DataSource = datas.ToList();
            resetGridStyle();
        }

        private void But_search_Click(object sender, EventArgs e)
        {
            queryByKeyword();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
