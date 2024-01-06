using MudBlazor;

namespace WortEx.Frontend;

public static class Theme
{
    public static MudTheme DefaultTheme => GetDefaultTheme();
    
    private static MudTheme GetDefaultTheme()
    {
        var primaryColor = "#864acf";
        var darkColor = "#242424"; // You can customize this color for the dark background

        var mudTheme = new MudTheme()
        {
            Palette = new PaletteDark()
            {
                Primary = primaryColor,
                Background = darkColor,
                DrawerBackground = darkColor,
                DrawerText = "rgba(255, 255, 255, 0.7)",
                AppbarBackground = darkColor,
                AppbarText = "rgba(255, 255, 255, 0.7)",
                Success = "#4caf50",
                Info = "#2196f3",
                Warning = "#ff9800",
                Error = "#f44336",
            },
            Typography = new Typography()
            {
                Default = new() { FontSize = "16px", FontFamily = new []{"Roboto", "Arial", "sans-serif"} }
            },
        };

        return mudTheme;
    }
}