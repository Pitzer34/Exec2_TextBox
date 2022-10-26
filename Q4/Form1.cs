using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCarCash.Text = string.Empty;
            lblPeopleCash.Text = string.Empty;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int Car;
            try
            {
                Car = GetCar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int People;
            try
            {
                People = GetPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            int totalCar = Car * 200;
            int totalPeople = People * 60;

            lblCarCash.Text = totalCar.ToString() + "元";
            lblPeopleCash.Text = totalPeople.ToString() + "元";
        }

        private int GetPeople()
        {
            string input = txtPeople.Text;
            bool isInt = int.TryParse(input, out int People);

            if (isInt == false)
            {
                throw new Exception("格式錯誤");
            }
            return People;
        }

        private int GetCar()
        {
            string input = txtCar.Text;
            bool isInt = int.TryParse(input, out int Car);

            if (isInt == false)
            {
                throw new Exception("格式錯誤");
            }
            return Car;
        }
    }
}
