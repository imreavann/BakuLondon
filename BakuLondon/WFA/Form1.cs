using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.baku;
            TimeZoneInfo bakuTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Azerbaijan Standard Time");
            label1.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, bakuTimeZone).ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.london;
            TimeZoneInfo londonTimeZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            label1.Text = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, londonTimeZone).ToString("HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
