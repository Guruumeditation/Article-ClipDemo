using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace ClipDemo
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;
            var anim = Resources["Storyboard1"] as Storyboard;
            anim.Begin();
        }
    }
}
