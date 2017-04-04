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

namespace SpecsBoss.FirstTimeSetup
{
    public partial class ThemeSelector : Form
    {
        DarkTheme dt = new DarkTheme();
        LightTheme lt = new LightTheme();

        public ThemeSelector()
        {
            InitializeComponent();
        }

        private void ThemeSelector_Load(object sender, EventArgs e)
        {
            Preferences.Default.ConfiguredColors = true;
            Preferences.Default.Save();
        }

        private void previewLight_Click(object sender, EventArgs e)
        {
            BackColor = lt.formBackgroundColor;

            themeSelectorTitle.BackColor = lt.formBackgroundColor;
            themeSelectorTitle.ForeColor = lt.infoLabelColor;

            selectDark.BackColor = lt.formBackgroundColor;
            selectLight.BackColor = lt.formBackgroundColor;
            previewDark.BackColor = lt.formBackgroundColor;
            previewLight.BackColor = lt.formBackgroundColor;

            selectLight.ForeColor = lt.infoLabelColor;
            selectDark.ForeColor = lt.infoLabelColor;
            previewLight.ForeColor = lt.infoLabelColor;
            previewDark.ForeColor = lt.infoLabelColor;
        }

        private void previewDark_Click(object sender, EventArgs e)
        {
            BackColor = dt.formBackgroundColor;

            themeSelectorTitle.BackColor = dt.formBackgroundColor;
            themeSelectorTitle.ForeColor = dt.infoLabelColor;

            selectDark.BackColor = dt.formBackgroundColor;
            selectLight.BackColor = dt.formBackgroundColor;
            previewDark.BackColor = dt.formBackgroundColor;
            previewLight.BackColor = dt.formBackgroundColor;

            selectLight.ForeColor = dt.infoLabelColor;
            selectDark.ForeColor = dt.infoLabelColor;
            previewLight.ForeColor = dt.infoLabelColor;
            previewDark.ForeColor = dt.infoLabelColor;
        }

        private void selectLight_Click(object sender, EventArgs e)
        {
            Preferences.Default.DarkTheme = false;
            Preferences.Default.Save();

            Application.Restart();
        }

        private void selectDark_Click(object sender, EventArgs e)
        {
            Preferences.Default.DarkTheme = true;
            Preferences.Default.Save();

            Application.Restart();
        }
    }
}
