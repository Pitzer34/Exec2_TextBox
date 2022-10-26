using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            double rows = 0;
            try
            {
                rows = GetRows();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            
            string msg = CheckInfo(rows);

            MessageBox.Show(msg);

        }

        private double GetRows()
        {
            string input = txtNumber.Text;
            bool isDouble = double.TryParse(input, out double rows);

            if (isDouble == false)
            {
                throw new Exception("請輸入整數");
            }
            return rows;
           
        }

        private string CheckInfo(double rows)
        {
            string msg;
            if (rows > 99 || rows <= 1)
            {
                msg ="\"不在\"1~99範圍內";
            }
            else
            {
                msg = "\"在\"1~99範圍內";
            }
            return msg;
        }
    }
}
