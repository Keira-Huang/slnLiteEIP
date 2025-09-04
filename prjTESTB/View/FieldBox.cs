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
    public partial class FieldBox : UserControl
    {
        public FieldBox()
        {
            InitializeComponent();
        }

        public string fieldName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public char passwordChar
        {
            get { return textBox1.PasswordChar; }
            set { textBox1.PasswordChar = value; }
        }

        public char PasswordChar { get; internal set; }

        public string fieldValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

    }
}
