using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Kullanımı_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label1.Text = bugun.ToString();
            label2.Text = bugun.AddDays(5).ToString() + " 5 gün eklendi."; 
            label3.Text = bugun.AddMonths(2).ToString() + " 2 ay eklendi.";
            label4.Text = bugun.AddYears(2).ToString() + " 2 yıl eklendi.";
            label5.Text = bugun.AddHours(3).ToString() + " 3 saat eklendi.";
            label6.Text = bugun.AddMinutes(15).ToString() + " 15 dakika eklendi.";
            label7.Text = bugun.AddSeconds(20).ToString() + " 20 saniye eklendi.";
        }


    }
}

