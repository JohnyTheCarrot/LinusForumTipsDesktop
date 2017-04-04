using LinusForumTipsDesktop.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinusForumTipsDesktop.MainWindow
{
    public partial class Main : Form
    {
        NavigationHelper navhelper = new NavigationHelper();

        bool fullscreen;
        bool fullscreenRequest;

        // Create our enums


        //Instantiate them

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            title.Text = ProductName;
            settingsButton.Text = "\xE115";           
            closeButton.Text = "\xE10A";
            feedbackButton.Text = "\xE170";

            title.BackColor = BackColor;
            settingsButton.BackColor = BackColor;
            closeButton.BackColor = BackColor;
            feedbackButton.BackColor = BackColor;
            fullscreenSwitcherButton.BackColor = BackColor;

            checkFullscreen();
        }

        private void windowManagement()
        {
            if(fullscreenRequest == true && fullscreen == false)
            {
                WindowState = FormWindowState.Maximized;
                fullscreen = true;
            }
            else if(fullscreenRequest == false && fullscreen == true)
            {
                WindowState = FormWindowState.Normal;
                fullscreen = false;
            }
        }

        private void checkFullscreen()
        {
            if(fullscreen == false)
            {
                fullscreenSwitcherButton.Text = "\xE740";
            }
            else if(fullscreen == true)
            {
                fullscreenSwitcherButton.Text = "\xE73F";
            }           
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            navhelper.openSettings();
        }

        private void fullscreenSwitcherButton_Click(object sender, EventArgs e)
        {
            if (fullscreen == false)
            {
                fullscreenRequest = true;
            }
            else if (fullscreen == true)
            {
                fullscreenRequest = false;
            }

            windowManagement();
            checkFullscreen();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
