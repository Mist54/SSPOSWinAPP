using System.Windows.Forms;

namespace SSPOS.GUI
{
    public static class Master
    {
        public static DialogResult ShowMessageBox(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            // Display the message box and return the result
            return MessageBox.Show(message, caption, buttons, icon);
        }

        public  static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowSuccess(string message)
        {
            return MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowWarning(string message)
        {
            return MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
