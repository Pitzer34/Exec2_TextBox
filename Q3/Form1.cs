using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBirth_Click(object sender, EventArgs e)
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

            string result = BirthCheck(Date);
            MessageBox.Show(result);

        }

        private string BirthCheck(DateTime Date)
        {
            string result;
            
            int year = Date.Year;
            int NowYear = DateTime.Now.Year;
            
            if (NowYear-year >= 13)
            {
                result = "已滿13歲";
            }
            else
            {
                result = "未滿13歲";
            }
            return result;
        }

        private DateTime DateCheck()
        {
            string input = txtBirth.Text;
            bool isDate = DateTime.TryParse(input, out DateTime Day);

            if (isDate == false)
            {
                throw new Exception("格式錯誤");
            }
            return Day;

        }
    }
}
