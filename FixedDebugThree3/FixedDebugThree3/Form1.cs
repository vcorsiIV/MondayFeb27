﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // This declaration is in the correct place.
        // total is outside the method so it can remain a running total.
        double total = 0;
        private void totalButton_Click(object sender, EventArgs e)
        {
            //Needed .Text.Trim() to allow the convert to work
            double num = Convert.ToDouble(textBox1.Text.Trim());
            total = num;
            //need to change comma to +
            outputLabel.Text = "Running total: "+ total;
        }
    }
}
