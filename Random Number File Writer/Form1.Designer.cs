namespace Random_Number_File_Writer
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
            this.numFilesTextBox = new System.Windows.Forms.TextBox();
            this.filesLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.numListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numFilesTextBox
            // 
            this.numFilesTextBox.Location = new System.Drawing.Point(254, 64);
            this.numFilesTextBox.Name = "numFilesTextBox";
            this.numFilesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numFilesTextBox.TabIndex = 0;
            // 
            // filesLabel
            // 
            this.filesLabel.AutoSize = true;
            this.filesLabel.Location = new System.Drawing.Point(12, 67);
            this.filesLabel.Name = "filesLabel";
            this.filesLabel.Size = new System.Drawing.Size(224, 13);
            this.filesLabel.TabIndex = 1;
            this.filesLabel.Text = "Enter the number of random files to hold in file:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(69, 297);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(161, 297);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(254, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numListBox
            // 
            this.numListBox.FormattingEnabled = true;
            this.numListBox.Location = new System.Drawing.Point(125, 90);
            this.numListBox.Name = "numListBox";
            this.numListBox.Size = new System.Drawing.Size(144, 199);
            this.numListBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 332);
            this.Controls.Add(this.numListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.filesLabel);
            this.Controls.Add(this.numFilesTextBox);
            this.Name = "Form1";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numFilesTextBox;
        private System.Windows.Forms.Label filesLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ListBox numListBox;
    }
}

