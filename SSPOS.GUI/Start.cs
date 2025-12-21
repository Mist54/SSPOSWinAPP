using MaterialSkin;
using System;
using System.Windows.Forms;
namespace SSPOS.GUI
{
    public static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplyTheme(true);
            Application.Run(new SplashScreen());


        }


        public static void ApplyTheme(bool theme)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            // Set the theme (light or dark)
            materialSkinManager.Theme = theme ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.LIGHT;

            // Apply the appropriate color scheme using the ColorPalette
            materialSkinManager.ColorScheme = new ColorScheme(
                    ColorPalette.GetPrimaryColor(theme),        // Primary color
                    ColorPalette.GetPrimaryLightColor(theme),   // Primary light color
                    ColorPalette.GetPrimaryLightColor(theme),   // Same for highlights
                    ColorPalette.GetAccentColor(theme),         // Accent color
                    theme ? TextShade.BLACK : TextShade.WHITE   // Text shade based on theme
                );
        }
    }


    #region helper


    #endregion helper
}
