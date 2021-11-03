using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows;
using Microsoft.Win32;

namespace Product_Key_Finder
{
    public partial class MainWindow : Window
    {
        private string userName = "N/A";
        private string userOS = "N/A";
        private string userKey = "N/A";
        private string userSerial = "N/A";
        private string userCPU = "N/A";
        private string userRAM = "N/A";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try {
                // Get computer name.
                userName = Environment.MachineName;
                txtUser.Text = userName;

                // Get computer os.
                var os = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>() select x.GetPropertyValue("Caption")).FirstOrDefault();
                os = os != null ? os.ToString() : "N/A";
                userOS = os.ToString();
                txtOS.Text = userOS;

                // Get computer key.
                userKey = KeyDecoder.GetWindowsProductKey();
                txtKey.Text = userKey;

                // Get computer serial.
                ManagementObject os1 = new ManagementObject("Win32_OperatingSystem=@");
                userSerial = (string)os1["SerialNumber"];
                txtSerial.Text = userSerial;

                // Get computer CPU.
                ManagementObjectSearcher os2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
                foreach (ManagementObject mo in os2.Get()) {
                    userCPU = (string)mo["Name"];
                }
                txtCPU.Text = userCPU;

                // Get computer RAM.
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection os3 = mc.GetInstances();
                foreach (ManagementObject item in os3) {
                    userRAM = Convert.ToString(Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / 1048576 / 1024, 0)) + " GB";
                }
                txtRAM.Text = userRAM;
            }
            catch { 
            }
        }

        private void btnToClipboard_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(userKey);
        }

        private void btnToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = userName.Replace(' ', '_').ToLower() + ".txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == true)
            {
                string bodyText =
                    $"System Name : {userName}\n" +
                    $"Operating System : {userOS}\n" +
                    $"Product Key : {userKey}\n" +
                    $"Device Serial : {userSerial}\n" +
                    $"Device CPU : {userCPU}\n" +
                    $"Avaible RAM : {userRAM}\n\n" +
                    "------------------------- \n" +
                    "Decoded by : MariusBinary";
                File.WriteAllText(save.FileName, bodyText);
            }
        }

        private void btnToEmail_Click(object sender, RoutedEventArgs e)
        {
            string subjectText = $"Product Key of {userName}";
            string bodyText =
                $"System Name : {userName}%0D%0A" +
                $"Operating System : {userOS}%0D%0A" +
                $"Product Key : {userKey}%0D%0A" +
                $"Device Serial : {userSerial}%0D%0A" +
                $"Device CPU : {userCPU}%0D%0A" +
                $"Avaible RAM : {userRAM}%0D%0A%0D%0A" +
                "-------------------------%0D%0A" +
                "Decoded by : MariusBinary";
            Process.Start($"mailto:?subject={subjectText}&body={bodyText}");
        }

        private void btnToPage2_Click(object sender, RoutedEventArgs e)
        {
            tabPage1.Visibility = Visibility.Collapsed;
            tabPage2.Visibility = Visibility.Visible;
        }

        private void btnToPage1_Click(object sender, RoutedEventArgs e)
        {
            tabPage1.Visibility = Visibility.Visible;
            tabPage2.Visibility = Visibility.Collapsed;
        }
    }
}
