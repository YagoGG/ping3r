using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// For ping purposes
using System.Net;
using System.Net.NetworkInformation;

// For multithreading
using System.Threading;

using System.Diagnostics;   // DEBUG

namespace WindowsFormsApplication2 
{

    public partial class MainForm : Form 
    {
        byte i = 0; // IP loop variable
        Device[] netDevices = new Device[255];

        public MainForm() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                lb_netstatus.Text = "UP! (everything OK)";
                lb_netstatus.ForeColor = Color.Green;
                bt_run.Enabled = true;
            }
            else
            {
                lb_netstatus.Text = "DOWN! (no network detected)";
                lb_netstatus.ForeColor = Color.Red;
            }
            ImageList imglist = new ImageList();
            imglist.Images.Add(Image.FromFile("nodeimg.png"));
        }

        class Device
        {
            public IPAddress ip;

            Ping pingSender = new Ping();
            PingReply pingReply;

            public Device(string inIP)
            {
                ip = IPAddress.Parse(inIP); 
            }
            // Displays a message box with device's IP address
            public void ShowIP()    // DEBUG
            {
                MessageBox.Show(ip.ToString());
            }
            // Checks if device is active
            public bool IsUp()
            {
                pingSender.Send(ip, 2000);
                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void CheckDevice()
        {
            netDevices[i] = new Device("192.168.1." + i);

            if (netDevices[i].IsUp())
            {
                MessageBox.Show(netDevices[i].ip.ToString() + " is currently UP", "Device up");
            }
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            double progress = 0;    // Progress bar variable

            for (i = 0; i <= 254; i++)
            {
                Thread devThread = new Thread(new ThreadStart(CheckDevice));
                devThread.Start();

                progress += 0.39;
                pb_progress.Value = (int)Math.Round(progress);
            }
            pb_progress.Value = 100;
        }
    }
}