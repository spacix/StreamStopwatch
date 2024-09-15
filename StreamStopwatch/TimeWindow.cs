using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamStopwatch
{
    public partial class TimeWindow : Form
    {
        bool mouseDown = false;
        private System.Windows.Forms.Timer RefreshTime;
        private IContainer components;
        Point lastLocation;
        private void TimeWindow_MouseDown(object? sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TimeWindow_MouseMove(object? sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TimeWindow_MouseUp(object? sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private readonly StopWatchService StopWatchService;
        public TimeWindow(StopWatchService stopWatchService)
        {
            StopWatchService = stopWatchService;
            InitializeComponent();
            lastLocation = new Point(this.Left, this.Top);
        }

        private Label TimeLabel;

        private void InitializeComponent()
        {
            components = new Container();
            TimeLabel = new Label();
            RefreshTime = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // TimeLabel
            // 
            TimeLabel.Dock = DockStyle.Fill;
            TimeLabel.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimeLabel.Location = new Point(0, 0);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(220, 80);
            TimeLabel.TabIndex = 0;
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            TimeLabel.MouseDown += TimeWindow_MouseDown;
            TimeLabel.MouseMove += TimeWindow_MouseMove;
            TimeLabel.MouseUp += TimeWindow_MouseUp;
            // 
            // RefreshTime
            // 
            RefreshTime.Enabled = true;
            RefreshTime.Interval = 200;
            RefreshTime.Tick += RefreshTime_Tick;
            // 
            // TimeWindow
            // 
            BackColor = Color.Black;
            ClientSize = new Size(220, 80);
            Controls.Add(TimeLabel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimeWindow";
            Text = "Timeer";
            FormClosing += TimeWindow_OnClosing;
            Shown += TimeWindow_OnShown;
            MouseDown += TimeWindow_MouseDown;
            MouseMove += TimeWindow_MouseMove;
            MouseUp += TimeWindow_MouseUp;
            ResumeLayout(false);
        }

        private void TimeWindow_OnShown(object? sender, EventArgs args)
        {
            RefreshTime.Start();
        }

        private void TimeWindow_OnClosing(object? sender, EventArgs args)
        {
            RefreshTime.Stop();
        }

        private void RefreshTime_Tick(object? sender, EventArgs e)
        {
            TimeLabel.Text = StopWatchService.GetTime().ToString("hh':'mm':'ss");
        }
    }
}
