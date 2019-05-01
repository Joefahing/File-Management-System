using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileWatcherInterface
{
    public partial class FileWatcher : Form
    {

        public FileWatcher()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            label2.Text = exportButton.Text;
            importFileControl.Visible = false;
            exportControl.Visible = true;
            stopWindowService();

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            
            label2.Text = dashboardButton.Text;
            importFileControl.Visible = false;
            exportControl.Visible = false;
            stopWindowService();
        
        }

        private void trackButton_Click(object sender, EventArgs e)
        {
            delayTimer();
            label2.Text = trackButton.Text;
            importFileControl.Visible = true;
            exportControl.Visible = false;

            
           
        }

        private void importFileControl_Load(object sender, EventArgs e)
        {
            importFileControl.Visible = false;
        }

        private void exportControl_Load(object sender, EventArgs e)
        {
           exportControl.Visible = false;
        }

        private void closeIconImage_Click(object sender, EventArgs e)
        {

        }

        private void optionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FileWatcher_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopWindowService();
        }

        private void stopWindowService()
        {
            ServiceController service = new ServiceController("File Management System");
            if (service.Status == ServiceControllerStatus.Running)
            {
                service.Stop();
            }
        }

        private void FileWatcher_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(@"C:\Program Files (x86)\uWindsor\FileManagementSystem\"))
            {
                Directory.CreateDirectory(@"C:\Program Files (x86)\uWindsor\FileManagementSystem\");
            }
        }

        private void delayTimer()
        {
            Task.Delay(100).Wait();
        }

        private void exportControl_Leave(object sender, EventArgs e)
        {
            stopWindowService();
        }


    }
}
