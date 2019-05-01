namespace FileWatcherInterface
{
    partial class ImportFileControl
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.exportToFileButton = new System.Windows.Forms.Button();
            this.exportFileTextField = new System.Windows.Forms.TextBox();
            this.exportFileButton = new System.Windows.Forms.Button();
            this.Source = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectFileButton.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileButton.Location = new System.Drawing.Point(422, 24);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(30, 25);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "....";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(126, 24);
            this.directoryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.directoryTextBox.Multiline = true;
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.ReadOnly = true;
            this.directoryTextBox.Size = new System.Drawing.Size(290, 25);
            this.directoryTextBox.TabIndex = 2;
            // 
            // exportToFileButton
            // 
            this.exportToFileButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.exportToFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportToFileButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToFileButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportToFileButton.Location = new System.Drawing.Point(190, 208);
            this.exportToFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportToFileButton.Name = "exportToFileButton";
            this.exportToFileButton.Size = new System.Drawing.Size(120, 30);
            this.exportToFileButton.TabIndex = 5;
            this.exportToFileButton.Text = "Export File";
            this.exportToFileButton.UseVisualStyleBackColor = false;
            this.exportToFileButton.Click += new System.EventHandler(this.exportToFileButton_Click);
            // 
            // exportFileTextField
            // 
            this.exportFileTextField.Location = new System.Drawing.Point(126, 106);
            this.exportFileTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportFileTextField.Multiline = true;
            this.exportFileTextField.Name = "exportFileTextField";
            this.exportFileTextField.ReadOnly = true;
            this.exportFileTextField.Size = new System.Drawing.Size(290, 25);
            this.exportFileTextField.TabIndex = 7;
            // 
            // exportFileButton
            // 
            this.exportFileButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.exportFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportFileButton.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportFileButton.Location = new System.Drawing.Point(422, 107);
            this.exportFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportFileButton.Name = "exportFileButton";
            this.exportFileButton.Size = new System.Drawing.Size(30, 25);
            this.exportFileButton.TabIndex = 6;
            this.exportFileButton.Text = "....";
            this.exportFileButton.UseVisualStyleBackColor = false;
            this.exportFileButton.Click += new System.EventHandler(this.exportFileButton_Click);
            // 
            // Source
            // 
            this.Source.AutoSize = true;
            this.Source.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Source.Location = new System.Drawing.Point(3, 22);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(65, 19);
            this.Source.TabIndex = 8;
            this.Source.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 9;
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
            this.Exit.TabIndex = 10;
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
            this.progBar.TabIndex = 11;
            this.progBar.Click += new System.EventHandler(this.progBar_Click);
            // 
            // ImportFileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.exportFileTextField);
            this.Controls.Add(this.exportFileButton);
            this.Controls.Add(this.exportToFileButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImportFileControl";
            this.Size = new System.Drawing.Size(480, 318);
            this.Load += new System.EventHandler(this.ImportFileControl_Load);
            this.Leave += new System.EventHandler(this.ImportFileControl_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button exportToFileButton;
        private System.Windows.Forms.TextBox exportFileTextField;
        private System.Windows.Forms.Button exportFileButton;
        private System.Windows.Forms.Label Source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ProgressBar progBar;
    }
}
