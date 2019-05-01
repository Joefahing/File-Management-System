namespace FileWatcherInterface
{
    partial class FileWatcher
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
            this.optionPanel = new System.Windows.Forms.Panel();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.trackButton = new System.Windows.Forms.Button();
            this.iconPanel = new System.Windows.Forms.Panel();
            this.exportButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exportControl = new FileWatcherInterface.ExportControl();
            this.importFileControl = new FileWatcherInterface.ImportFileControl();
            this.optionPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionPanel
            // 
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.optionPanel.Controls.Add(this.dashboardButton);
            this.optionPanel.Controls.Add(this.trackButton);
            this.optionPanel.Controls.Add(this.iconPanel);
            this.optionPanel.Controls.Add(this.exportButton);
            this.optionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.optionPanel.Location = new System.Drawing.Point(0, 0);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(148, 382);
            this.optionPanel.TabIndex = 0;
            this.optionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.optionPanel_Paint);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dashboardButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Location = new System.Drawing.Point(0, 45);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(148, 28);
            this.dashboardButton.TabIndex = 2;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // trackButton
            // 
            this.trackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.trackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.trackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackButton.ForeColor = System.Drawing.Color.White;
            this.trackButton.Location = new System.Drawing.Point(0, 70);
            this.trackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackButton.Name = "trackButton";
            this.trackButton.Size = new System.Drawing.Size(148, 28);
            this.trackButton.TabIndex = 3;
            this.trackButton.Text = "Track File";
            this.trackButton.UseVisualStyleBackColor = false;
            this.trackButton.Click += new System.EventHandler(this.trackButton_Click);
            // 
            // iconPanel
            // 
            this.iconPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(145)))), ((int)(((byte)(14)))));
            this.iconPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPanel.Location = new System.Drawing.Point(0, 0);
            this.iconPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPanel.Name = "iconPanel";
            this.iconPanel.Size = new System.Drawing.Size(148, 42);
            this.iconPanel.TabIndex = 0;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.ForeColor = System.Drawing.Color.White;
            this.exportButton.Location = new System.Drawing.Point(0, 94);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(148, 28);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Export Files";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.headerPanel.Controls.Add(this.label2);
            this.headerPanel.Controls.Add(this.textBox1);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(148, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(566, 40);
            this.headerPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dashboard";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // exportControl
            // 
            this.exportControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exportControl.Location = new System.Drawing.Point(216, 62);
            this.exportControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportControl.Name = "exportControl";
            this.exportControl.Size = new System.Drawing.Size(480, 318);
            this.exportControl.TabIndex = 3;
            this.exportControl.Load += new System.EventHandler(this.exportControl_Load);
            this.exportControl.Leave += new System.EventHandler(this.exportControl_Leave);
            // 
            // importFileControl
            // 
            this.importFileControl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.importFileControl.Location = new System.Drawing.Point(216, 62);
            this.importFileControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.importFileControl.Name = "importFileControl";
            this.importFileControl.Size = new System.Drawing.Size(480, 318);
            this.importFileControl.TabIndex = 2;
            this.importFileControl.Load += new System.EventHandler(this.importFileControl_Load);
            // 
            // FileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 382);
            this.Controls.Add(this.exportControl);
            this.Controls.Add(this.importFileControl);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.optionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileWatcher";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileWatcher_FormClosed);
            this.Load += new System.EventHandler(this.FileWatcher_Load);
            this.optionPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Button trackButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Panel iconPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private ImportFileControl importFileControl;
        private ExportControl exportControl;
    }
}

