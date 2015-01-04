using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// For managing IP addresses and sending pings
using System.Net;
using System.Net.NetworkInformation;

// For multithreading
using System.Threading;

using System.Diagnostics;   // DEBUG

namespace WindowsFormsApplication2
{

    public partial class MainForm : Form
    {
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
            tv_results.ImageList = imglist;
        }

        public class Device
        {
            public String ip;
            public String hostName = null;
            public bool available = false;
            public Ping pingSender = new Ping();
            public PingReply reply;

            public void IsUP() // Pings this device, to know if it's up or down
            {
                reply = pingSender.Send(ip, 2000);
                if (reply.Status == IPStatus.Success)
                {
                    available = true;
                }

                // Memory releasing
                pingSender = null;
                reply = null;
                GC.Collect(); 
                hostName = GetHost();
            }

            public string GetHost()
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                return hostEntry.HostName;
            }
        }

        void UpdateTree(Device[,] devicesArray)
        {
            tv_results.Nodes.Clear();
            tv_results.BeginUpdate();
            for (byte net = 0; net <= 2; net++)
            {
                for (byte i = 0; i <= 254; i++)
                {
                    if (devicesArray[net, i].available == true) // Is available
                    {
                        if (devicesArray[net, i].hostName != null)  // Has got hostname
                        {
                            tv_results.Nodes.Add(devicesArray[net, i].ip + " (" + devicesArray[net, i].hostName + ")");
                        }
                        else
                        {
                            tv_results.Nodes.Add(devicesArray[net, i].ip);
                        }
                    }
                }
            }
            tv_results.EndUpdate();
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            double progress = 0;    // Progress bar variable
            Device[,] netDevices = new Device[255, 255];  // Network devices array

            for (byte net = 0; net <= 2; net++)
            {
                for (byte i = 0; i <= 254; i++)
                {
                    netDevices[net, i] = new Device();

                    netDevices[net, i].ip = "192.168." + net + "." + i;
                    // Multithreading system (for faster completion)
                    Thread devThread = new Thread(new ThreadStart(netDevices[net, i].IsUP));
                    devThread.Start();
                }
                // Progress bar advance
                progress += 0.39;
                pb_progress.Value = (int)Math.Round(progress);
            }
            pb_progress.Value = 100;    // Set progress bar to full (because of precission loss on 0.39 additions)
            UpdateTree(netDevices);
        }
    }
}
