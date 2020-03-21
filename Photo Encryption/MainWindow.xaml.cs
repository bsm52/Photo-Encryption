using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Photo_Encryption
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

        private void FileUploadBtn_Click(object sender, RoutedEventArgs e)
        {
            // holds the name of the file given by the user
            string filename = "";
            
            // prompt for the file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.FileName;
            }

            // create a temp directory to hold the image if one doesn't exist
            if(!System.IO.Directory.Exists(Path.Combine(Environment.CurrentDirectory, "temp")))
            {
                System.IO.Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "temp"));
            }

            // copy the chosen file from the user to the temp directory
            System.IO.File.Copy(filename, Path.Combine(Environment.CurrentDirectory, "temp", Path.GetFileName(filename)));

            // make the new filename's path in the temp directory
            filename = Path.Combine(Environment.CurrentDirectory, "temp", Path.GetFileName(filename));

            MessageBox.Show(filename);
        }
        
        private void DisplayImagePreview(string filename)
        {

        }

        private void ChangeStyleBtn_Click(object sender, RoutedEventArgs e)
        {
            StyleChanger.ChangeLabelSize(60);
        }

        private void Newindowbtn_Click(object sender, RoutedEventArgs e)
        {
            Testwindow test = new Testwindow();
            test.Show();
        }
    }
}
