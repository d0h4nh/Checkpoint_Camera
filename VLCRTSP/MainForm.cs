using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace VLCRTSP
{
    public partial class MainForm : Form
    {
        private VlcControl cam1 = new VlcControl();
        private VlcControl cam2 = new VlcControl();
        private VlcControl cam3 = new VlcControl();
        private VlcControl cam4 = new VlcControl();
        public MainForm()
        {
            InitializeComponent();
           


            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            var libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));

            cam1.BeginInit();
            cam1.VlcLibDirectory = libDirectory;
            cam1.Dock = DockStyle.Fill;
            cam1.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam1);

            cam2.BeginInit();
            cam2.VlcLibDirectory = libDirectory;
            cam2.Dock = DockStyle.Fill;
            cam2.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam2);

            cam3.BeginInit();
            cam3.VlcLibDirectory = libDirectory;
            cam3.Dock = DockStyle.Fill;
            cam3.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam3);

            cam4.BeginInit();
            cam4.VlcLibDirectory = libDirectory;
            cam4.Dock = DockStyle.Fill;
            cam4.EndInit();
            this.tableLayoutPanel1.Controls.Add(cam4);

            chkC1.Checked = true;
            chkC2.Checked = true;
            chkC3.Checked = true;
            chkC4.Checked = true;



            LoadCamera();


        }
        private string URIbuilder(string cam, string u, string p, string link)
        {

            return "rtsp://"+ u +":" + p + "@" + cam + ":554"+ link;
        }
        private void LoadCamera()
        {
            if (Properties.Settings.Default["Station"].ToString() == "1")
            {


                cam1.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam1"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam2.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam2"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam3.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam3"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam4.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam4"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));


            }
            else if (Properties.Settings.Default["Station"].ToString() == "2")
            {
                cam1.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam5"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam2.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam6"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam3.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam7"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
                cam4.Play(new Uri(URIbuilder(Properties.Settings.Default["Ipcam8"].ToString(), Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString(), Properties.Settings.Default["Viewlink"].ToString())));
            }
            this.Text = "Container Photo Capture - Station " + Properties.Settings.Default["Station"].ToString() + " - v2.0 By HanhDD ITNDP";
        }
        private void btnCap_Click(object sender, EventArgs e)
        {
            string filepath;
            if (txtcntrno.Text != "")
            {
                filepath = Properties.Settings.Default["SaveLocation"] + "\\" + txtcntrno.Text + "-" + DateTime.Now.ToString("yyMMddHHmmss");
            }
            else
            {
                filepath = Properties.Settings.Default["SaveLocation"] + "\\" + DateTime.Now.ToString("yyMMddHHmmss");
            }
            if (Properties.Settings.Default["Station"].ToString() == "1")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    
                    if (chkC1.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam1"] + Properties.Settings.Default["CaptureLink"], filepath + "-01.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-01.jpg";
                    }
                    if (chkC2.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam2"] + Properties.Settings.Default["CaptureLink"], filepath + "-02.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-02.jpg";
                    }
                    if (chkC3.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam3"] + Properties.Settings.Default["CaptureLink"], filepath + "-03.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-03.jpg";
                    }
                    if (chkC4.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam4"] + Properties.Settings.Default["CaptureLink"], filepath + "-04.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-04.jpg";
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (Properties.Settings.Default["Station"].ToString() == "2")
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (chkC1.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam5"] + Properties.Settings.Default["CaptureLink"], filepath + "-01.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-01.jpg";
                    }
                    if (chkC2.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam6"] + Properties.Settings.Default["CaptureLink"], filepath + "-02.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-02.jpg";
                    }
                    if (chkC3.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam7"] + Properties.Settings.Default["CaptureLink"], filepath + "-03.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-03.jpg";
                    }
                    if (chkC4.Checked == true)
                    {
                        requestFrame("http://" + Properties.Settings.Default["IpCam8"] + Properties.Settings.Default["CaptureLink"], filepath + "-04.jpg");
                        lblstat.Text = "Saved to: " + filepath + "-04.jpg";
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            Cursor.Current = Cursors.Default;
            txtcntrno.Text = "";
            txtcntrno.Focus();
        }

        private void requestFrame(string url, string filename)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(Properties.Settings.Default["User"].ToString(), Properties.Settings.Default["Password"].ToString());
            request.Proxy = null;

            request.BeginGetResponse(result => {
                finishRequestFrame(result, request, filename);
            }, null);

        }
        void finishRequestFrame(IAsyncResult result,
                              HttpWebRequest request,
                              string filename)
        {
            using (HttpWebResponse response =
             (HttpWebResponse)request.EndGetResponse(result))
            {
                Stream responseStream = response.GetResponseStream();

                using (Bitmap frame = new Bitmap(responseStream))
                {
                    if (frame != null)
                    {
                        Bitmap camsaved = (Bitmap)frame.Clone();
                        camsaved.Save(filename);
                    }
                    else
                    {
                        MessageBox.Show("Không lưu được ảnh, vui lòng thử lại", "Lỗi");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCFG form = new frmCFG();
            form.Show();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadCamera();
        }

        private void txtcntrno_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnCap_Click(sender,e);
            }
        }
    }
}

