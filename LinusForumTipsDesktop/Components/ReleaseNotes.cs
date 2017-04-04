using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using LinusForumTipsDesktop.Settings;
using LinusForumTipsDesktop.Themes;

namespace Lithium_Browser.Components
{
    public partial class ReleaseNotes : Form
    {
        ChromiumWebBrowser chromium;

        string _address;

        public ReleaseNotes(string versionTag)
        {
            InitializeComponent();

            _address = "https://github.com/AluminiumTech/SpecsBoss/releases/" + versionTag;
        }
        private void ReleaseNotes_Load(object sender, EventArgs e)
        {
           Text = "SpecsBoss "+  Application.ProductVersion + " Release Notes";

            //apple whatever theme the user has chosen
            applyTheme();

            //Load the changelog for this version in the chromium component

            chromium = new ChromiumWebBrowser(_address);

            panel.Controls.Add(chromium);
        }

        private void applyTheme()
        {
            if(Preferences.Default.DarkTheme == false)
            {
                LightTheme lt = new LightTheme();

                BackColor = lt.formBackgroundColor;

                okBtn.BackColor = lt.formBackgroundColor;
                okBtn.ForeColor = lt.infoLabelColor;
            }
            else if (Preferences.Default.DarkTheme ==true)
            {
                DarkTheme dt = new DarkTheme();

                BackColor = dt.formBackgroundColor;

                okBtn.BackColor = dt.formBackgroundColor;
                okBtn.ForeColor = dt.infoLabelColor;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
