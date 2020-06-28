namespace TaskManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.processList_Names = new System.Windows.Forms.ListBox();
            this.killButton = new System.Windows.Forms.Button();
            this.processList_PIDs = new System.Windows.Forms.ListBox();
            this.killPID = new System.Windows.Forms.Button();
            this.getInfoButton_PID = new System.Windows.Forms.Button();
            this.updateList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.getInfoButton_Name = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.perfCounter = new System.Diagnostics.PerformanceCounter();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.ramLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.ramCount = new System.Diagnostics.PerformanceCounter();
            this.label2 = new System.Windows.Forms.Label();
            this.osVerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perfCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCount)).BeginInit();
            this.SuspendLayout();
            // 
            // processList_Names
            // 
            this.processList_Names.FormattingEnabled = true;
            this.processList_Names.Location = new System.Drawing.Point(13, 52);
            this.processList_Names.Name = "processList_Names";
            this.processList_Names.Size = new System.Drawing.Size(185, 160);
            this.processList_Names.TabIndex = 0;
            // 
            // killButton
            // 
            this.killButton.Location = new System.Drawing.Point(13, 218);
            this.killButton.Name = "killButton";
            this.killButton.Size = new System.Drawing.Size(75, 23);
            this.killButton.TabIndex = 1;
            this.killButton.Text = "Kill";
            this.killButton.UseVisualStyleBackColor = true;
            this.killButton.Click += new System.EventHandler(this.killButton_Click);
            // 
            // processList_PIDs
            // 
            this.processList_PIDs.FormattingEnabled = true;
            this.processList_PIDs.Location = new System.Drawing.Point(360, 52);
            this.processList_PIDs.Name = "processList_PIDs";
            this.processList_PIDs.Size = new System.Drawing.Size(185, 160);
            this.processList_PIDs.TabIndex = 3;
            // 
            // killPID
            // 
            this.killPID.Location = new System.Drawing.Point(360, 218);
            this.killPID.Name = "killPID";
            this.killPID.Size = new System.Drawing.Size(75, 23);
            this.killPID.TabIndex = 4;
            this.killPID.Text = "Kill";
            this.killPID.UseVisualStyleBackColor = true;
            this.killPID.Click += new System.EventHandler(this.killPID_Click);
            // 
            // getInfoButton_PID
            // 
            this.getInfoButton_PID.Location = new System.Drawing.Point(470, 218);
            this.getInfoButton_PID.Name = "getInfoButton_PID";
            this.getInfoButton_PID.Size = new System.Drawing.Size(75, 23);
            this.getInfoButton_PID.TabIndex = 5;
            this.getInfoButton_PID.Text = "Get Info";
            this.getInfoButton_PID.UseVisualStyleBackColor = true;
            this.getInfoButton_PID.Click += new System.EventHandler(this.getInfoButton_PID_Click);
            // 
            // updateList
            // 
            this.updateList.Location = new System.Drawing.Point(13, 248);
            this.updateList.Name = "updateList";
            this.updateList.Size = new System.Drawing.Size(532, 26);
            this.updateList.TabIndex = 6;
            this.updateList.Text = "Update Lists";
            this.updateList.UseVisualStyleBackColor = true;
            this.updateList.Click += new System.EventHandler(this.updateList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please use Task Manager if able.\r\nThis is only a workaround for machines with Exp" +
    "licit Deny TASKMGR in GPO.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(410, 37);
            this.title.TabIndex = 8;
            this.title.Text = "Funey\'s Process Manager";
            // 
            // getInfoButton_Name
            // 
            this.getInfoButton_Name.Enabled = false;
            this.getInfoButton_Name.Location = new System.Drawing.Point(123, 218);
            this.getInfoButton_Name.Name = "getInfoButton_Name";
            this.getInfoButton_Name.Size = new System.Drawing.Size(75, 23);
            this.getInfoButton_Name.TabIndex = 2;
            this.getInfoButton_Name.Text = "Get Info";
            this.getInfoButton_Name.UseVisualStyleBackColor = true;
            this.getInfoButton_Name.Click += new System.EventHandler(this.getInfoButton_Name_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(204, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.TabIndex = 9;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cpuUsageLabel.Location = new System.Drawing.Point(202, 52);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(63, 13);
            this.cpuUsageLabel.TabIndex = 10;
            this.cpuUsageLabel.Text = "CPU Usage";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // perfCounter
            // 
            this.perfCounter.CategoryName = "Processor";
            this.perfCounter.CounterName = "% Processor Time";
            this.perfCounter.InstanceName = "_Total";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cpuLabel.Location = new System.Drawing.Point(309, 70);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(33, 13);
            this.cpuLabel.TabIndex = 11;
            this.cpuLabel.Text = "100%";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ramLabel.Location = new System.Drawing.Point(310, 120);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(33, 13);
            this.ramLabel.TabIndex = 14;
            this.ramLabel.Text = "100%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(203, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "RAM Usage";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(205, 118);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 16);
            this.progressBar2.TabIndex = 12;
            // 
            // ramCount
            // 
            this.ramCount.CategoryName = "Memory";
            this.ramCount.CounterName = "% Committed Bytes In Use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(202, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "RAM Usage includes pagefile.";
            // 
            // osVerLabel
            // 
            this.osVerLabel.AutoSize = true;
            this.osVerLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.osVerLabel.Location = new System.Drawing.Point(204, 159);
            this.osVerLabel.Name = "osVerLabel";
            this.osVerLabel.Size = new System.Drawing.Size(114, 39);
            this.osVerLabel.TabIndex = 16;
            this.osVerLabel.Text = "Platform: Win32NT\r\nVersion: 9.0198.29\r\nPagefile Size: 4096MB\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Get More System Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(554, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.osVerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ramLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateList);
            this.Controls.Add(this.getInfoButton_PID);
            this.Controls.Add(this.killPID);
            this.Controls.Add(this.processList_PIDs);
            this.Controls.Add(this.getInfoButton_Name);
            this.Controls.Add(this.killButton);
            this.Controls.Add(this.processList_Names);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Funey\'s Process Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processList_Names;
        private System.Windows.Forms.Button killButton;
        private System.Windows.Forms.ListBox processList_PIDs;
        private System.Windows.Forms.Button killPID;
        private System.Windows.Forms.Button getInfoButton_PID;
        private System.Windows.Forms.Button updateList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button getInfoButton_Name;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter perfCounter;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Diagnostics.PerformanceCounter ramCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label osVerLabel;
        private System.Windows.Forms.Button button1;
    }
}

