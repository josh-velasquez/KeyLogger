using KeyLogger.KeyboardUtil;
using System.Windows;

namespace KeyLogger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        KeyboardListener listener;
        private void OnStartRecorderClick(object sender, RoutedEventArgs e)
        {
            listener = new KeyboardListener();
            listener.KeyDown += new RawKeyEventHandler(KeyboardRecorder);
            clear.IsEnabled = false;
            start.IsEnabled = false;
        }

        private void KeyboardRecorder(object sender, RawKeyEventArgs args)
        {
            keyboard_textbox.Text += args.ToString();
        }

        private void OnStopRecorderClick(object sender, RoutedEventArgs e)
        {
            start.IsEnabled = true;
            clear.IsEnabled = true;
            listener.Dispose();
        }

        private void OnClearRecorderClick(object sender, RoutedEventArgs e)
        {
            keyboard_textbox.Clear();
        }

    }
}
