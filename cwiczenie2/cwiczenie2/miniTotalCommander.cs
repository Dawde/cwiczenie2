﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenie2
{
    public partial class miniTotalCommander : UserControl
    {

        public event Action<miniTotalCommander> LoadDrivers;
        public miniTotalCommander()
        {
            InitializeComponent();
        }

      
        public string currentPath
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string[] Drivers
        {
            set
            {
                if (value != null)
                    comboBox1.Items.AddRange(value);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (LoadDrivers != null)
                LoadDrivers(this);
        }

        private void miniTotalCommander_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.TabIndex != -1)
            {
                currentPath = comboBox1.Text;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
