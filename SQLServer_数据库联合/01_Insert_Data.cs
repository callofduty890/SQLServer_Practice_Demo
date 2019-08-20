using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer_数据库联合
{
    public partial class _01_Insert_Data : Form
    {
        //定义窗体类型
        Form form1;

        public _01_Insert_Data(Form form)
        {
            InitializeComponent();
            //将传入的窗体对象赋值给本类的form1
            this.form1 = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void _01_Insert_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Insert_data = null;

        }
    }
}
