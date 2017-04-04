using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AluminiumCore;
using LinusForumTipsDesktop.Settings;

namespace SpecsBoss.FirstTimeSetup
{
    public partial class LanguageSelector : Form
    {

        ErrorMessages error = new ErrorMessages();

        public LanguageSelector()
        {
            InitializeComponent();
        }

        private void LanguageSelector_Load(object sender, EventArgs e)
        {
                
        }
        private void doneBtn_Click(object sender, EventArgs e)
        {
            if(languageBox.Text == "English")
            {
          //      helper.applyLanguages("English");
            }
            else if(languageBox.Text == "Romanian")
            {
                Preferences.Default.LanguageChosen = "Romanian";
                Preferences.Default.Save();

                error.throwError("Unable to select Romanian.", "SpecsBoss does not support Romanian currently however a translation attempt is in progress. Thank you for understanding.");
            }
            else if(languageBox.Text == "Korean")
            {
            //    helper.applyLanguages("Korean");
            }

            Preferences.Default.ConfiguredLanguages = true;
            Preferences.Default.Save();

            Application.Restart();
        }
    }
}
