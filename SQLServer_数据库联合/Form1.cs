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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //定义窗体类型对象
        public static _01_Insert_Data Insert_data=null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Insert_data==null)
            {
                //实例化窗体
                Insert_data = new _01_Insert_Data(this);
                //指定窗体位置
                Insert_data.StartPosition = FormStartPosition.CenterScreen;
                //显示窗体
                Insert_data.Show();
            }  
            else
            {
                //激活窗体处于最前面
                Insert_data.Activate();
                //设置窗体状态
                Insert_data.WindowState = FormWindowState.Normal;

            }
        }

        //定义对象-静态成员对象
        public static _02_Select_Data Select_data = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (Select_data==null)
            {
                //实例化窗体对象
                Select_data = new _02_Select_Data(this);
                //指定窗体位置
                Select_data.StartPosition = FormStartPosition.CenterScreen;
                //显示窗体
                Select_data.Show();
            }
            else
            {
                //激活窗体处于最前面
                Select_data.Activate();
                //设置窗体状态
                Select_data.WindowState = FormWindowState.Normal;
            }
        }

        //修改窗体
        public static _03_Alter_Data Alter_Data = null;
        private void button4_Click(object sender, EventArgs e)
        {
            if (Alter_Data == null)
	        {
                //实例化窗体
                Alter_Data = new _03_Alter_Data(this);
                //指定窗体位置
                Alter_Data.StartPosition = FormStartPosition.CenterScreen;
                //显示窗体
                Alter_Data.Show();		            
	        }
            else
            {
                //激活窗体处于最前面
                Alter_Data.Activate();
                //设置窗体状态
                Alter_Data.WindowState = FormWindowState.Normal;
            }
        }

        //导入
        public static _04_Import_Data Import_Data = null;
        private void button5_Click(object sender, EventArgs e)
        {
            if (Import_Data == null)
            {
                //实例化窗体
                Import_Data = new _04_Import_Data(this);
                //指定窗体位置
                Import_Data.StartPosition = FormStartPosition.CenterScreen;
                //显示窗体
                Import_Data.Show();
            }
            else
            {
                //激活窗体处于最前面
                Import_Data.Activate();
                //设置窗体状态
                Import_Data.WindowState = FormWindowState.Normal;
            }
        }
        //导出
        public static _05_Export_Data Export_Data = null;
        private void button6_Click(object sender, EventArgs e)
        {
            if (Export_Data == null)
            {
                //实例化窗体
                Export_Data = new _05_Export_Data(this);
                //指定窗体位置
                Export_Data.StartPosition = FormStartPosition.CenterScreen;
                //显示窗体
                Export_Data.Show();
            }
            else
            {
                //激活窗体处于最前面
                Export_Data.Activate();
                //设置窗体状态
                Export_Data.WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
