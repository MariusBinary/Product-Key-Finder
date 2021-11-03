using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Key_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetOS();
            GetKey();
        }

        private void GetOS()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>() select x.GetPropertyValue("Caption")).FirstOrDefault();
            name = name != null ? name.ToString() : "Unknown";
            lb_os.Text = "Product Key (" + name + ") :";
        }

        private void GetKey()
        {
            tbKey.Text = KeyDecoder.GetWindowsProductKey();
        }

        private void btnCopyToClipboar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbKey.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = getOS().ToLower() + ".txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                string createText = "Date : " + DateTime.Now + Environment.NewLine + "OS : " + getOS() + Environment.NewLine + "Product Key : " + tbKey.Text;
                File.WriteAllText(save.FileName, createText);
            }
        }

        public string getOS()
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>() select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Unknown";
        }
    }
}
