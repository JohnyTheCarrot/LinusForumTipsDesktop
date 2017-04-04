using System;
using System.Windows.Forms;
using LinusForumTipsDesktop.Settings;
using LinusForumTipsDesktop.Themes;

namespace Lithium_Browser.Components
{
    public partial class SettingsMenu : Form
    {

        public SettingsMenu()
        {
            InitializeComponent();
        }
        private void SettingsRefresh()
        {
            if (Preferences.Default.DarkTheme == true)
            {
                theme.Checked = true;
            }
            if (Preferences.Default.DarkTheme == false)
            {
                theme.Checked = false;
            }
        }
        private void Apply()
        {
            if (theme.Checked == true)
            {
                Preferences.Default.DarkTheme = true;
                Preferences.Default.Save();
            }
            if (theme.Checked == false)
            {
                Preferences.Default.DarkTheme = false;
                Preferences.Default.Save();
            }      

            Preferences.Default.Save();
            URLs.Default.Save();
        }
        private void SettingsMenu_Load(object sender, EventArgs e)
        {

                  theme.Enabled = true;
            SettingsRefresh();

            loadTheme();
        }
        private void loadTheme()
        {
            if(Preferences.Default.DarkTheme == true)
            {
                loadDarkTheme();
            }
            else if(Preferences.Default.DarkTheme == false)
            {
                loadLightTheme();
            }
        }
        private void loadLightTheme()
        {
            LightTheme lt = new LightTheme();

            //Set the theme for all the tabControl pages
            BackColor = lt.formBackgroundColor;
            ForeColor = lt.infoLabelColor;

            preferencedPage.ForeColor = lt.infoLabelColor;
            preferencedPage.BackColor = lt.formBackgroundColor;

            tellemtryPage.ForeColor = lt.labelColor;
            tellemtryPage.BackColor = lt.formBackgroundColor;

            thirdPartyPage.ForeColor = lt.infoLabelColor;
            thirdPartyPage.BackColor = lt.formBackgroundColor;

            doneBtn.ForeColor = lt.infoLabelColor;
            doneBtn.BackColor = lt.formBackgroundColor;

            applyBtn.ForeColor = lt.infoLabelColor;
            applyBtn.BackColor = lt.formBackgroundColor;

            aboutLabel.ForeColor = lt.labelColor;
            aboutLabel.BackColor = lt.formBackgroundColor;

            theme.ForeColor = lt.labelColor;
            theme.BackColor = lt.formBackgroundColor;

            tellemtry.ForeColor = lt.labelColor;
            tellemtry.BackColor = lt.formBackgroundColor;
        }
        private void loadDarkTheme()
        {
            DarkTheme dt = new DarkTheme();

            //Set the theme for all the tabControl pages
            BackColor = dt.formBackgroundColor;
            ForeColor = dt.infoLabelColor;

            preferencedPage.ForeColor = dt.infoLabelColor;
            preferencedPage.BackColor = dt.formBackgroundColor;

            tellemtryPage.ForeColor = dt.labelColor;
            tellemtryPage.BackColor = dt.formBackgroundColor;

            thirdPartyPage.ForeColor = dt.infoLabelColor;
            thirdPartyPage.BackColor = dt.formBackgroundColor;

            //Set the themes for the rest of the view

            doneBtn.ForeColor = dt.infoLabelColor;
            doneBtn.BackColor = dt.formBackgroundColor;

            applyBtn.ForeColor = dt.infoLabelColor;
            applyBtn.BackColor = dt.formBackgroundColor;

            aboutLabel.ForeColor = dt.labelColor;
            aboutLabel.BackColor = dt.formBackgroundColor;

            theme.ForeColor = dt.labelColor;
            theme.BackColor = dt.formBackgroundColor;

            tellemtry.ForeColor = dt.labelColor;
            tellemtry.BackColor = dt.formBackgroundColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Apply();
        }
        private void Done_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void theme_CheckedChanged(object sender, EventArgs e)
        {
            if(theme.Checked == true)
            {
                Preferences.Default.DarkTheme = true;
                Preferences.Default.Save();
            }
            else
            {
                Preferences.Default.DarkTheme = false;
                Preferences.Default.Save();
            }
        }
    
        private void SettingsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            URLs.Default.Save();
            Preferences.Default.Save();
        }
    }
}