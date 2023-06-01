using MaterialSkin;
using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Diagnostics;


namespace OOP_course
{
    public partial class FormAbout : MaterialForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }
    

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ant04ch");
        }
    }
}
