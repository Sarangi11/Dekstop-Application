﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Navigate : Form
    {
        public Navigate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member_Task member_Task = new Member_Task();
            member_Task.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
        }
    }
}
