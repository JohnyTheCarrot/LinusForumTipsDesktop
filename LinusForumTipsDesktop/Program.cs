using AluminiumCore;
using LinusForumTipsDesktop.Settings;
using Lithium_Browser.Components;
using Microsoft.VisualBasic.Devices;
using SpecsBoss.FirstTimeSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinusForumTipsDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string os = new ComputerInfo().OSFullName;

            App app = new App();

            if (os.Contains("Windows Vista"))
            {
                try
                {
                    app.openURL("https://github.com/AluminiumTech/SpecsBoss/wiki/OS-Support", System.Diagnostics.ProcessWindowStyle.Normal);
                }
                catch
                {
                    ErrorMessages error = new ErrorMessages();

                    error.throwError("OS Not Supported", "The version of Windows installed on your PC is not supported by SpecsBoss. Please upgrade to a newer version of Windows to use SpecsBoss.");
                }
            }
            //if specs boss works on a supported version of Windows then load SpecsBoss.
            else if (os.Contains("Windows 7") || os.Contains("Windows 8") || os.Contains("Windows 8.1") || os.Contains("Windows 10"))
            {
                if (Preferences.Default.ViewedLicense == false)
                {
                    Application.Run(new License());
                }
                else if (Preferences.Default.ConfiguredLanguages == false)
                {
                    Application.Run(new LanguageSelector());
                }
                else if (Preferences.Default.ConfiguredColors == false)
                {
                    Application.Run(new ThemeSelector());
                }
                else
                {
                //    Application.Run(new );
                }
            }
            else
            {
                app.openURL("https://github.com/AluminiumTech/SpecsBoss/wiki/OS-Support", System.Diagnostics.ProcessWindowStyle.Normal);
            }


        }
    }
    }
