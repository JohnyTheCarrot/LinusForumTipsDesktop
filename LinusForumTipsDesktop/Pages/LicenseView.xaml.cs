using LinusForumTipsDesktop.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LinusForumTipsDesktop.Pages
{
    /// <summary>
    /// Interaction logic for LicenseView.xaml
    /// </summary>
    public partial class LicenseView : Page
    {
        public LicenseView()
        {
            InitializeComponent();

            if(Preference.Default.Language == "English")
            {
                licenseBrowser.Address = URLs.Default.englishLicenseURL;
            }
            else if(Preference.Default.Language == "Korean")
            {
                licenseBrowser.Address = URLs.Default.koreanLicenseURL;
            }
        }
    }
}
