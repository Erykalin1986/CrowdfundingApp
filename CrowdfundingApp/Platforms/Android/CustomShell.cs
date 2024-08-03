using Android.Content.Res;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Microsoft.Maui.Platform;

namespace CrowdfundingApp.Platforms.Android
{
    public class CustomShell : ShellRenderer
    {
        public CustomShell()
        {

        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomShellBottomNavViewAppearance();
        }
    }

    public class CustomShellBottomNavViewAppearance : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ResetAppearance(BottomNavigationView bottomView)
        {
            throw new NotImplementedException();
        }

        public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
            bottomView.ItemIconSize = 75;
            bottomView.SetBackgroundColor(Color.FromRgb(1, 197,255).ToPlatform());
            bottomView.ItemIconTintList = ColorStateList.ValueOf(Colors.White.ToPlatform());
            bottomView.SetPadding(100, 50, 100, 50);

            // Changed the selected tab icon color.
            BottomNavigationMenuView? bottomNavView = bottomView.GetChildAt(0) as BottomNavigationMenuView;

            for (int i = 0; i < bottomNavView?.ChildCount; i++)
            {
                BottomNavigationItemView? item = bottomNavView.GetChildAt(i) as BottomNavigationItemView;
                if (item != null && item.Selected) item.SetIconTintList(ColorStateList.ValueOf(Color.FromRgb(77, 213, 255).ToPlatform()));
            }
        }
    }
}
