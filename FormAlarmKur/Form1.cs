using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//Yeni kütüphane

namespace FormAlarmKur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer alarm = new WMPLib.WindowsMediaPlayer();

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == DateTime.Now.Hour && numericUpDown2.Value == DateTime.Now.Minute)
            {
                timer1.Stop();
                alarm.URL = "alarm.mp3";
                alarm.controls.play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            label1.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alarm.controls.stop();
            button1.Enabled = true;
            button2.Enabled = false;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
