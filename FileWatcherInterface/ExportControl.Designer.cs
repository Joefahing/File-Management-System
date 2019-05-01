namespace FileWatcherInterface
{
    partial class ExportControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exportFromButton = new System.Windows.Forms.Button();
            this.exportfromTextField = new System.Windows.Forms.TextBox();
            this.ExportToButton = new System.Windows.Forms.Button();
            this.exportToTextField = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.Source = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // exportFromButton
            // 
            this.exportFromButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportFromButton.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFromButton.Location = new System.Drawing.Point(422, 24);
            this.exportFromButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportFromButton.Name = "exportFromButton";
            this.exportFromButton.Size = new System.Drawing.Size(30, 25);
            this.exportFromButton.TabIndex = 1;
            this.exportFromButton.Text = "....";
            this.exportFromButton.UseVisualStyleBackColor = false;
            this.exportFromButton.Click += new System.EventHandler(this.exportFromButton_Click);
            // 
            // exportfromTextField
            // 
            this.exportfromTextField.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportfromTextField.Location = new System.Drawing.Point(126, 24);
            this.exportfromTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportfromTextField.Multiline = true;
            this.exportfromTextField.Name = "exportfromTextField";
            this.exportfromTextField.ReadOnly = true;
            this.exportfromTextField.Size = new System.Drawing.Size(290, 25);
            this.exportfromTextField.TabIndex = 3;
            // 
            // ExportToButton
            // 
            this.ExportToButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExportToButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportToButton.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToButton.Location = new System.Drawing.Point(422, 107);
            this.ExportToButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExportToButton.Name = "ExportToButton";
            this.ExportToButton.Size = new System.Drawing.Size(30, 25);
            this.ExportToButton.TabIndex = 4;
            this.ExportToButton.Text = "....";
            this.ExportToButton.UseVisualStyleBackColor = false;
            this.ExportToButton.Click += new System.EventHandler(this.ExportToButton_Click);
            // 
            // exportToTextField
            // 
            this.exportToTextField.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToTextField.Location = new System.Drawing.Point(126, 106);
            this.exportToTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportToTextField.Multiline = true;
            this.exportToTextField.Name = "exportToTextField";
            this.exportToTextField.ReadOnly = true;
            this.exportToTextField.Size = new System.Drawing.Size(290, 25);
            this.exportToTextField.TabIndex = 5;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportButton.Location = new System.Drawing.Point(190, 208);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 30);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.Location = new System.Drawing.Point(3, 22);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(65, 19);
            this.Source.TabIndex = 9;
            this.Source.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(332, 208);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 30);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // progBar
            // 
            this.progBar.BackColor = System.Drawing.SystemColors.Window;
            this.progBar.ForeColor = System.Drawing.SystemColors.Window;
            this.progBar.Location = new System.Drawing.Point(0, 310);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(480, 5);
            this.progBar.TabIndex = 12;
            // 
            // ExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.exportToTextField);
            this.Controls.Add(this.ExportToButton);
            this.Controls.Add(this.exportfromTextField);
            this.Controls.Add(this.exportFromButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportControl";
            this.Size = new System.Drawing.Size(480, 318);
            this.Load += new System.EventHandler(this.ExportControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportFromButton;
        private System.Windows.Forms.TextBox exportfromTextField;
        private System.Windows.Forms.Button ExportToButton;
        private System.Windows.Forms.TextBox exportToTextField;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar progBar;
    }
}
