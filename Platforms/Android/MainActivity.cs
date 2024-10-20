using Android.App;
using Android.Content.PM;
using Android.OS;
using System.Diagnostics;

namespace PhoneWord.Platforms.Android;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class MainActivity : MauiAppCompatActivity
{
    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
