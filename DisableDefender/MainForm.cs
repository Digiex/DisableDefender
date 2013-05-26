using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
    }
}
