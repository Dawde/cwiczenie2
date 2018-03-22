using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cwiczenie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //miniTCPanel1.CurrentPath = @"c:\";
            miniTotalCommander1.LoadDrivers += MiniTCPanel1_LoadDrivers;
            //DriveInfo
            //Path
            //Directory
            //File
        }

        private void MiniTCPanel1_LoadDrivers(miniTotalCommander obj)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string> dyski = new List<string> { };
            foreach (DriveInfo d in drives)
            {
                if(d.IsReady) dyski.Add(d.Name);
            }


            miniTotalCommander1.Drivers = dyski.ToArray();
                }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
