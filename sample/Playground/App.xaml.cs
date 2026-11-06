<<<<<<< HEAD
using Plugin.Firebase.CloudMessaging;

=======
#nullable enable
>>>>>>> 47bb62628259049bd4344688053114b9118c0de9
namespace Playground;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

<<<<<<< HEAD
        MainPage = new AppShell();
        CrossFirebaseCloudMessaging.Current.NotificationReceived += async (s, po) => {

        };
=======
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
>>>>>>> 47bb62628259049bd4344688053114b9118c0de9
    }
}