using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.Maui;
using Plugin.Fingerprint;

[Activity(Label = "YourAppName", Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        // Call the base method first to ensure proper activity initialization
        base.OnCreate(savedInstanceState);

        // Set the current activity resolver
        CrossFingerprint.SetCurrentActivityResolver(() => this);
    }
}
