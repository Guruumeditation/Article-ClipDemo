
using Windows.UI.Xaml.Media.Animation;

namespace ClipDemo
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            var anim = Resources["Storyboard1"] as Storyboard;
            anim.Begin();
        }
    }
}
