using LinusForumTipsDesktop.Settings;
using LinusForumTipsDesktop.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecsBoss.Components
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Create a new instance of AluminiumCoreLibrary
        AluminiumCore.App app = new AluminiumCore.App();

        private void About_Load(object sender, EventArgs e)
        {
            applyTheme();

            specsverLabel.Text += ": " + ProductVersion;
            aluminiumcoreLibVersionLabel.Text += ": " + Versions.Default.AluminiumCore;
            buildLabel.Text += ": " + Versions.Default.BuildDate;
        }
        Color backgroundColour;
        Color labelColour;
        Color infolabelColour;

        private void applyTheme()
        {
            LightTheme lt = new LightTheme();
            DarkTheme dt = new DarkTheme();

            if (Preferences.Default.DarkTheme == false)
            {
                backgroundColour = lt.formBackgroundColor;
                infolabelColour = lt.infoLabelColor;
                labelColour = lt.labelColor;
            }
            else if (Preferences.Default.DarkTheme == true)
            {
                backgroundColour = dt.formBackgroundColor;
                infolabelColour = dt.infoLabelColor;
                labelColour = dt.labelColor;
            }

            BackColor = backgroundColour;

            specsverLabel.BackColor = backgroundColour;
            specsverLabel.ForeColor = infolabelColour;

            buildLabel.BackColor = backgroundColour;
            buildLabel.ForeColor = infolabelColour;

            aluminiumcoreLibVersionLabel.BackColor = backgroundColour;
            aluminiumcoreLibVersionLabel.ForeColor = infolabelColour;

            ossLabel.BackColor = backgroundColour;
            ossLabel.ForeColor = labelColour;
        }
    }
}
