using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPOS.GUI
{
    public partial class BlockingLoader : Form
    {
        public BlockingLoader(string message = "Processing...")
        {
            InitializeComponent();
            lblLoaderMessage.Text = message; // Update label with a custom message
        }

        public void UpdateMessage(string message)
        {
            lblLoaderMessage.Text = message;
        }

        private void BlockingLoader_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
