using System.Drawing;

namespace SSPOS.GUI
{
    /// <summary>
    /// Color pallet class help us to change the color and theme in centerised way 
    /// </summary>
    public static class ColorPalette
    {

        public static class LightTheme
        {
            public static Color PrimaryColor = Color.FromArgb(104, 147, 202);
            public static Color PrimaryLightColor = Color.FromArgb(66, 120, 189);
            public static Color AccentColor = Color.FromArgb(73, 66, 189);
            public static Color TextColor = Color.FromArgb(255, 255, 255);
        }

        public static class DarkTheme
        {
            public static Color PrimaryColor = Color.FromArgb(104, 147, 202); //Top Color   
            public static Color PrimaryLightColor = Color.FromArgb(66, 120, 189); //Second color
            public static Color AccentColor = Color.FromArgb(73, 66, 189);
            public static Color TextColor = Color.FromArgb(50, 50, 50);
        }



        public static Color GetPrimaryColor(bool theme)
        {
            return theme ? LightTheme.PrimaryColor : DarkTheme.PrimaryColor;
        }

        public static Color GetPrimaryLightColor(bool theme)
        {
            return theme ? LightTheme.PrimaryLightColor : DarkTheme.PrimaryLightColor;
        }

        public static Color GetAccentColor(bool theme)
        {
            return theme ? LightTheme.AccentColor : DarkTheme.AccentColor;
        }

        public static Color GetTextColor(bool theme)
        {
            return theme ? LightTheme.TextColor : DarkTheme.TextColor;
        }

    }
}
