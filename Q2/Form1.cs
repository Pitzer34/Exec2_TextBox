using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            DateTime Date;
            try
            {
                Date = DateCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            DateTime dtToday = DateTime.Today;
            
            if (Date <= dtToday)
            {
                MessageBox.Show("輸入日期未超過今日");
            }
            else
            {
                MessageBox.Show("輸入日期超過今日");
            }

        }

        private DateTime DateCheck()
        {
            string input = txtDay.Text;
            bool isDate = DateTime.TryParse(input, out DateTime Day);

            if (isDate == false)
            {
                throw new Exception("格式錯誤");
            }
            return Day;

        }
    }
}
