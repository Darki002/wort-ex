namespace WortEx.Frontend.Layouts;

public partial class MainLayout
{
    private bool drawerOpen = true;

    private void ToggleDrawer() => drawerOpen = !drawerOpen;
}