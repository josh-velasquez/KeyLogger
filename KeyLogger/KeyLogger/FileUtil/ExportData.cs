using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace KeyLogger.FileUtil
{
    class ExportData
    {
        public bool WriteFile(string title, string[] data)
        {
            string new_title = title + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter output_file = new StreamWriter(Path.Combine(path, new_title)))
                {
                    foreach (string line in data)
                    {
                        output_file.WriteLine(line);
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Error in exporting to text file.", "Status", MessageBoxButton.OK);
            }
            return false;
        }
        public bool WriteText(string title, TextBox data)
        {
            string new_title = title + DateTime.Now.ToString("_yyyyMMdd_HHmmss") + ".txt";
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter output_file = new StreamWriter(Path.Combine(path, new_title)))
                {
                    output_file.WriteLine(data.Text);
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Error in exporting to text file.", "Status", MessageBoxButton.OK);
            }
            return false;
        }
    }
}
