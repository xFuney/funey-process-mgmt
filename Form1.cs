using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManagement
{
    public partial class Form1 : Form
    {

        public Process[] processlist;
        public List<string> processNames = new List<string>();
        public String[] processNamesArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise permanent informational statistics.
            osVerLabel.Text = "Platform: " + Environment.OSVersion.Platform.ToString() + "\nVersion: " + Environment.OSVersion.Version.ToString() + "\nPagefile Size: " + Environment.SystemPageSize;
            // Get all processes, chuck into list.
            processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                processList_Names.Items.Add(theprocess.ProcessName);
                processList_PIDs.Items.Add(theprocess.Id);
                processNames.Add(theprocess.ProcessName);
            }
            processNamesArray = processNames.ToArray();
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            if (processList_Names.SelectedIndex < 0)
            {
                MessageBox.Show("Please select something before clicking this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to do this? You could break something.", "Killing Process...?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (dialogResult == DialogResult.Yes)
            {
                // KILL PROCESS
                try
                {
                    int pName = (int)processList_PIDs.Items[processList_Names.SelectedIndex];

                    Process.GetProcessById(pName).Kill();

                    MessageBox.Show("Program has been killed successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception ex)
                {
                    MessageBox.Show("Failed to kill program - do you have the correct permissions?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void killPID_Click(object sender, EventArgs e)
        {
            if (processList_PIDs.SelectedIndex < 0)
            {
                MessageBox.Show("Please select something before clicking this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to do this? You could break something.", "Killing Process...?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // KILL PROCESS
                try
                {
                    int pName = (int)processList_PIDs.Items[processList_PIDs.SelectedIndex];

                    Process.GetProcessById(pName).Kill();

                    MessageBox.Show("Program has been killed successfully.", "Success.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to kill program - do you have the correct permissions?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void getInfoButton_Name_Click(object sender, EventArgs e)
        {
            if (processList_PIDs.SelectedIndex < 0)
            {
                MessageBox.Show("Please select something before clicking this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get a process info

        }

        private void getInfoButton_PID_Click(object sender, EventArgs e)
        {
            if (processList_PIDs.SelectedIndex < 0)
            {
                MessageBox.Show("Please select something before clicking this button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get a process info
            int pName = (int)processList_PIDs.Items[processList_PIDs.SelectedIndex];

            Process processToSee = Process.GetProcessById(pName);

            MessageBox.Show("Name: " + processToSee.ProcessName + "\nPID: " + processToSee.Id, "Process Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateList_Click(object sender, EventArgs e)
        {
            // Disable all options.
            getInfoButton_Name.Enabled = false;
            getInfoButton_PID.Enabled = false;
            killButton.Enabled = false;
            killPID.Enabled = false;

            // Update
            processList_Names.Items.Clear();
            processList_PIDs.Items.Clear();

            // Get all processes, chuck into list.
            processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                processList_Names.Items.Add(theprocess.ProcessName);
                processList_PIDs.Items.Add(theprocess.Id);
                processNames.Add(theprocess.ProcessName);
            }
            processNamesArray = processNames.ToArray();

            // Enable all options.
            //getInfoButton_Name.Enabled = true;
            getInfoButton_PID.Enabled = true;
            killButton.Enabled = true;
            killPID.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(perfCounter.NextValue());
            cpuLabel.Text = progressBar1.Value.ToString() + "%";

            progressBar2.Value = (int)(ramCount.NextValue());
            ramLabel.Text = progressBar2.Value.ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get more system info
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Windows Version: {0}\n", Environment.OSVersion);
            output.AppendFormat("AMD64 OS : {0}\n",
               Environment.Is64BitOperatingSystem ? "Yes" : "No");
            output.AppendFormat("Hostname : {0}\n", Environment.MachineName);
            output.AppendFormat("CPU Count : {0}\n", Environment.ProcessorCount);
            output.AppendFormat("SYSTEM32 Location : {0}\n", Environment.SystemDirectory);
            output.AppendFormat("Available Logical Drives : {0}\n",
                  String.Join(", ", Environment.GetLogicalDrives())
               .Replace("\\", String.Empty));

            MessageBox.Show(output.ToString(), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
