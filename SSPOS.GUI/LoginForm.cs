using MaterialSkin.Controls;
using SSPOS.BLL;
using System;
using System.Windows.Forms;
using SSPOS.GUI.Shared;

namespace SSPOS.GUI
{
    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        // Show or hide password based on the checkbox state
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Password = !chkShowPassword.Checked;
            txtPassword.Refresh();

        }

        // Close the application on clicking the close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        // Handle login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string userName = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text.Trim();

            // Authenticate the user with the entered plain-text password
            userAuthentication(userName, enteredPassword);
        }

        // User authentication logic
        private bool userAuthentication(string userName, string password)
        {
            // Display warning if username or password is empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                Master.ShowMessageBox("Username or password cannot be empty..!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Hardcoded admin credentials for demo purposes
            if (userName == "SA" && password == "SA")
            {
                OpenMainForm();
                return true;
            }

            // Fetch user from the database
            SystemUser systemUser = SystemUser.RetrieveByUserName(userName);
            if (systemUser != null)
            {
                //For Devs --> If you added the user directly uncomment the below code 
                //for first run
                if (!PasswordHash.IsHash(systemUser.Password))
                {
                    string hashedPassword = updateUserPasswordHash(userName, systemUser.Password);
                    if (!string.IsNullOrEmpty(hashedPassword))
                    {
                        systemUser.Password = hashedPassword;
                    }

                }


                // Verify the entered plain-text password against the stored hash
                if (PasswordHash.VerifyPassword(systemUser.Password, password))
                {
                    // Save username to settings
                    //Properties.Settings.Default.Username = userName;
                    //Properties.Settings.Default.Save(); // Ensure settings are persisted

                    _ = new SessionManager(systemUser.Name, systemUser.Password); //stores the user info


                    OpenMainForm();
                    return true;
                }
                else
                {
                    ShowAuthorizationError();
                    return false;
                }
            }
            else
            {
                ShowAuthorizationError();
                return false;
            }
        }

        // Display error message when authorization fails
        private void ShowAuthorizationError()
        {
            Master.ShowMessageBox("Incorrect username or password.", "Error in Authorization", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Open the main form and hide the login form
        private void OpenMainForm()
        {
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Show();
        }

        /// <summary>
        /// this Function is only for devs and demo purpose
        /// </summary>
        /// <param name="username"></param>
        /// <param name="enterdPassword"></param>
        private string updateUserPasswordHash(string username,string enterdPassword)
        {
            //this function will update the plain text to password hash of the user 
            //use it for only once for each user *only for devs
            SystemUser systemUser = SystemUser.RetrieveByUserName(username);
            if (systemUser != null)
            {
                string hashedPassword=PasswordHash.HashPassword(enterdPassword);
                systemUser.Password = hashedPassword;
                SystemUser.Update(systemUser.Id, systemUser.Name, systemUser.Password,
                    systemUser.Email, systemUser.Company, systemUser.Role, true, systemUser.Name, DateTime.Now, false);

                return hashedPassword;
            }
            else
            {
                return null;
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
