using Lithium_Browser.Components;
using SpecsBoss.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LinusForumTipsDesktop.Navigation
{
    class NavigationHelper
    {
        Thread settings;
        Thread about;
        Thread license;

        public void openSettings()
        {
            settings = new Thread(new ThreadStart(openSettingsThread));
            settings.Start();
        }
        private void openSettingsThread()
        {
            Form openSettings = new SettingsMenu();
            openSettings.ShowDialog();
        }
        public void openAbout()
        {
            about = new Thread(new ThreadStart(openAboutThread));
            about.Start();
        }
        private void openAboutThread()
        {
            Form openAbout = new About();
            openAbout.ShowDialog();
        }
        public void openLicense()
        {
            license = new Thread(new ThreadStart(openLicenseThread));
            license.Start();
        }
        private void openLicenseThread()
        {
            Form openLicense = new License();
            openLicense.ShowDialog();
        }
    }
}
