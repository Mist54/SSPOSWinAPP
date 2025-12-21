using System;
using System.Windows.Forms;

namespace SSPOS.GUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Interval = 100; // Set a suitable interval in milliseconds
            timer1.Enabled = true; // Start the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            SplashProgressBar.Increment(2);
            if (SplashProgressBar.Value >= 100)
            {
                timer1.Enabled = false;

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
