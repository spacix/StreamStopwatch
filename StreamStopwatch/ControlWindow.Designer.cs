namespace StreamStopwatch
{
    partial class ControlWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartStopButton = new Button();
            ResetButton = new Button();
            groupBox1 = new GroupBox();
            SetButton = new Button();
            timeTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Dock = DockStyle.Top;
            StartStopButton.Location = new Point(0, 0);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(204, 60);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "&Start";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Dock = DockStyle.Bottom;
            ResetButton.Location = new Point(0, 119);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(204, 60);
            ResetButton.TabIndex = 1;
            ResetButton.Text = "&Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SetButton);
            groupBox1.Controls.Add(timeTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 59);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Time Control";
            // 
            // SetButton
            // 
            SetButton.Location = new Point(117, 22);
            SetButton.Name = "SetButton";
            SetButton.Size = new Size(75, 23);
            SetButton.TabIndex = 1;
            SetButton.Text = "Set Time";
            SetButton.UseVisualStyleBackColor = true;
            SetButton.Click += SetButton_Click;
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(12, 22);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(100, 23);
            timeTextBox.TabIndex = 0;
            timeTextBox.Text = "00 : 00 : 00";
            // 
            // ControlWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 179);
            Controls.Add(groupBox1);
            Controls.Add(ResetButton);
            Controls.Add(StartStopButton);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ControlWindow";
            ShowIcon = false;
            Text = "Stopwatch";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartStopButton;
        private Button ResetButton;
        private GroupBox groupBox1;
        private TextBox timeTextBox;
        private Button SetButton;
    }
}
