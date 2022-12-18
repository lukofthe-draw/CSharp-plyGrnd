// "Create a form in C# that interacts //with different desktop services, letting you open and close them."

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ServiceControlForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get a list of all the services on the system
            ServiceController[] services = ServiceController.GetServices();

            // Add the service names to the list box
            foreach (ServiceController service in services)
            {
                listBox1.Items.Add(service.ServiceName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected service name
            string serviceName = listBox1.SelectedItem.ToString();

            // Get the service controller for the selected service
            ServiceController service = new ServiceController(serviceName);

            // Update the status label with the current status of the service
            label1.Text = "Status: " + service.Status.ToString();

            // Enable or disable the Start and Stop buttons based on the current status of the service
            if (service.Status == ServiceControllerStatus.Running)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (service.Status == ServiceControllerStatus.Stopped)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected service name
            string serviceName = listBox1.SelectedItem.ToString();

            // Get the service controller for the selected service
            ServiceController service = new ServiceController(serviceName);

            // Start the service
            service.Start();

            // Update the status label with the current status of the service
            label1.Text = "Status: " + service.Status.ToString();

            // Enable or disable the Start and Stop buttons based on the current status of the service
            if (service.Status == ServiceControllerStatus.Running)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (service.Status == ServiceControllerStatus.Stopped)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the selected service name
            string serviceName = listBox1.SelectedItem.ToString();

            // Get the service controller for the selected service
            ServiceController service = new ServiceController(serviceName);

            // Stop the service
            service.Stop();

            // Update the status label with the current status of the service
            label1.Text = "Status: " + service.Status.ToString();

            // Enable or disable 
