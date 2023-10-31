using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VLCRTSP

{
    public partial class frmCFG : Form
    {
        public frmCFG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default["SaveLocation"] = folderBrowserDialog1.SelectedPath;
            if (folderBrowserDialog1.SelectedPath!="") {
                Properties.Settings.Default["SaveLocation"] = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                Properties.Settings.Default["SaveLocation"] = textBox9.Text;
            }
            Properties.Settings.Default["IpCam1"] = textBox1.Text;
            Properties.Settings.Default["IpCam2"] = textBox2.Text;
            Properties.Settings.Default["IpCam3"] = textBox3.Text;
            Properties.Settings.Default["IpCam4"] = textBox4.Text;
            Properties.Settings.Default["IpCam5"] = textBox5.Text;
            Properties.Settings.Default["IpCam6"] = textBox6.Text;
            Properties.Settings.Default["IpCam7"] = textBox7.Text;
            Properties.Settings.Default["IpCam8"] = textBox8.Text;
            Properties.Settings.Default["User"] = txtuser.Text;
            Properties.Settings.Default["Password"] = txtpw.Text;
            Properties.Settings.Default["ViewLink"] = txtvl.Text;
            Properties.Settings.Default["CaptureLink"] = txtcl.Text;
            
            if (radioButton1.Checked)
            {
                Properties.Settings.Default["Station"] = "1";
            }
            else if (radioButton2.Checked)
            {
                Properties.Settings.Default["Station"] = "2";
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("Saved");
            reload();
         
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            reload();
        }       
        private void reload()
        {
            textBox1.Text = Properties.Settings.Default["IpCam1"].ToString();
            textBox2.Text = Properties.Settings.Default["IpCam2"].ToString();
            textBox3.Text = Properties.Settings.Default["IpCam3"].ToString();
            textBox4.Text = Properties.Settings.Default["IpCam4"].ToString();
            textBox5.Text = Properties.Settings.Default["IpCam5"].ToString();
            textBox6.Text = Properties.Settings.Default["IpCam6"].ToString();
            textBox7.Text = Properties.Settings.Default["IpCam7"].ToString();
            textBox8.Text = Properties.Settings.Default["IpCam8"].ToString();
            textBox9.Text = Properties.Settings.Default["SaveLocation"].ToString();
            txtuser.Text=Properties.Settings.Default["User"].ToString();
            txtpw.Text  =Properties.Settings.Default["Password"].ToString();
            txtvl.Text  =Properties.Settings.Default["ViewLink"].ToString();
            txtcl.Text = Properties.Settings.Default["CaptureLink"].ToString();
            if (Properties.Settings.Default["Station"].ToString() == "1" )
            {
                radioButton1.Checked=true;
            }
            else if (Properties.Settings.Default["Station"].ToString() == "2")
            {
                radioButton2.Checked = true;
            }

        }

        private void ConfigForm_Enter(object sender, EventArgs e)
        {
            textBox9.Text = folderBrowserDialog1.SelectedPath;
        }

        private void ConfigForm_Validated(object sender, EventArgs e)
        {
            textBox9.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
