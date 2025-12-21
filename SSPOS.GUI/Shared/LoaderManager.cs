using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPOS.GUI.Shared
{
    public class LoaderManager
    {
        private static BlockingLoader _loaderInstance;

        public static void Show(string message = "Processing...")
        {
            if (_loaderInstance == null)
            {
                _loaderInstance = new BlockingLoader(message)
                {
                    StartPosition = FormStartPosition.CenterParent,
                    //TopMost = true
                };
                Task.Run(() => _loaderInstance.ShowDialog());
            }
        }

        public static void UpdateMessage(string message)
        {
            if (_loaderInstance != null)
            {
                _loaderInstance.Invoke((Action)(() => _loaderInstance.UpdateMessage(message)));
            }
        }

        public static void Hide()
        {
            if (_loaderInstance != null)
            {
                _loaderInstance.Invoke((Action)(() =>
                {
                    _loaderInstance.Close();
                    _loaderInstance.Dispose();
                    _loaderInstance = null;
                }));
            }
        }
    }
}
