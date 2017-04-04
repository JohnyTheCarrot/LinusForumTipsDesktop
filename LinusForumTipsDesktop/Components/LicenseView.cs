using AluminiumCore;
using CefSharp.WinForms;
using LinusForumTipsDesktop.Settings;
using System;
using System.Windows.Forms;

namespace Lithium_Browser.Components
{
    public partial class License : Form
    {
        ErrorMessages error = new ErrorMessages();

        ChromiumWebBrowser chromium;

        string _address;

        public License()
        {
            InitializeComponent();
        }

        private void agree_Click(object sender, EventArgs e)
        {
            Preferences.Default.ViewedLicense = true;
            Preferences.Default.Save();

            Application.Restart();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            //Tell the user that we will be cancelling the current operation
            error.cancel();
        }

        private void License_Load(object sender, EventArgs e)
        {
           
    /*         if(Preferences.Default.LanguageChosen == "English")
            {
                _address = URLs.Default.licenseURL_English;
            }
            */
            _address = URLs.Default.licenseURL_English;

            /*
            else if(Preferences.Default.LanguageChosen == "")
                  {
                      _address = URLs.Default.licenseURL_Korean;
                  }
          */
            chromium = new ChromiumWebBrowser(_address);

            panel.Controls.Add(chromium);

            
        }
    }
}
