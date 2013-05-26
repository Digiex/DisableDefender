using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisableDefender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
                this.logoBox.Image = this.Icon.ToBitmap();
            }
            catch (Exception) { }
        }

        private void understandBox_CheckedChanged(object sender, EventArgs e)
        {
            disableButton.Enabled = understandBox.Checked;
        }

        private void xdaLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://forum.xda-developers.com/showthread.php?t=2265773");
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            int disable = 1;
            if (sender == enableButton)
            {
                disable = 0;
            }
#if !DEBUG
            try
#endif
            {
                var hklm = Environment.Is64BitOperatingSystem ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64) : Registry.LocalMachine;
                Privileges.EnablePrivilege(SecurityEntity.SE_TAKE_OWNERSHIP_NAME);
                using (RegistryKey regKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership))
                {
                    RegistrySecurity rs = regKey.GetAccessControl(AccessControlSections.None);
                    //rs.SetGroup(new NTAccount("Administrators"));
                    rs.SetOwner(WindowsIdentity.GetCurrent().User);
                    rs.SetAccessRuleProtection(false, false);

                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.FullControl, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.WriteKey, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.ChangePermissions, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.CreateLink, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.CreateSubKey, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.Delete, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.EnumerateSubKeys, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.ExecuteKey, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.Notify, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.QueryValues, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.ReadKey, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.ReadPermissions, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.SetValue, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.TakeOwnership, AccessControlType.Allow));
                    rs.AddAccessRule(new RegistryAccessRule(WindowsIdentity.GetCurrent().User, RegistryRights.WriteKey, AccessControlType.Allow));
                    regKey.SetAccessControl(rs);
                }
                using (RegistryKey regKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows Defender\", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.SetValue))
                {
                    regKey.SetValue("DisableAntiSpyware", disable);
                    regKey.SetValue("DisableAntiVirus", disable);
                }
                if (MessageBox.Show(this, "Done! For changes to take effect, the system needs to be restarted.\n\nWould you like to restart now?", "Done.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Process.Start("shutdown", "/r /t 0");
                }
            }
#if !DEBUG
            catch (Exception ex)
            {
                MessageBox.Show(this, "Please post this to the XDA thread (link in the app):\n"+ex.Message + "\n" + ex.Source + "\n" + ex.HelpLink + "\n" + ex.StackTrace, "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endif
        }
    }
}
