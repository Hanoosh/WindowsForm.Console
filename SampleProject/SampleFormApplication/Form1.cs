﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//this is important for async accessing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fconsole1.Write("this is an example line text!.",
                Color.FromName(comboBox1.Items[comboBox1.SelectedIndex].ToString()));//used SelectedIndex for preventing a crash
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(nameof(Color.Aqua));
            comboBox1.Items.Add(nameof(Color.Red));
            comboBox1.Items.Add(nameof(Color.Blue));
            comboBox1.Items.Add(nameof(Color.White));
            comboBox1.Items.Add(nameof(Color.Yellow));
            comboBox1.Items.Add(nameof(Color.LightBlue));
            comboBox1.Items.Add(nameof(Color.DarkSeaGreen));
            comboBox1.SelectedIndex = 3;

            fconsole1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fconsole1.ReadOnly = !fconsole1.ReadOnly;
            if (fconsole1.ReadOnly)
            {
                button4.Text = "ReadOnly (ON)";
            }
            else
            {
                button4.Text = "ReadOnly (OFF)";
                MessageBox.Show("some of features may work with readonly mode such as readline, read key, but now it is okey if until you see any error :)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fconsole1.WriteLine("this is an example line text!.",
            Color.FromName(comboBox1.Items[comboBox1.SelectedIndex].ToString()));//used SelectedIndex for preventing a crash
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fconsole1.WriteLine(" http://github.com/msx752/WindowsForm.Console",
            Color.FromName(comboBox1.Items[comboBox1.SelectedIndex].ToString()));//used SelectedIndex for preventing a crash)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fconsole1.ForeColor = Color.FromName(comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //needs improvement
                var line = fconsole1.ReadLine();
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fconsole1.WriteLine(" Press Any Key..",
             Color.FromName(comboBox1.Items[comboBox1.SelectedIndex].ToString()));//used SelectedIndex for preventing a crash)
            Task.Run(() =>
            //needs improvement
            {
                var key = fconsole1.ReadKey();
            });
        }
    }
}