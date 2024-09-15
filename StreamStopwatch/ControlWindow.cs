namespace StreamStopwatch
{
    public partial class ControlWindow : Form
    {
        public readonly TimeWindow timeWindow;
        public readonly StopWatchService StopwatchService;
        public ControlWindow(StopWatchService stopwatch)
        {
            timeWindow = new TimeWindow(stopwatch);
            StopwatchService = stopwatch;
            InitializeComponent();
            timeWindow.Show();
        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (StopwatchService.TimerEnabled)
            {
                StopwatchService.StopTimer();
                StartStopButton.Text = "&Start";
            }
            else
            {
                StopwatchService.StartTimer();
                StartStopButton.Text = "&Stop";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            StopwatchService.ResetTimer();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TryParse(String.Concat(timeTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)), out TimeSpan time))
            {
                StopwatchService.SetTime(time);
            }
            else
            {
                MessageBox.Show("Unable to parse time string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
