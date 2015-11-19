using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace ClipDemo.Control
{
    public class ClipControl : ContentControl
    {
        public ClipControl()
        {
            SizeChanged += ClipControl_SizeChanged;
        }

        private void ClipControl_SizeChanged(object sender, Windows.UI.Xaml.SizeChangedEventArgs e)
        {
            Clip = new RectangleGeometry {Rect = new Rect(new Point(0, 0), e.NewSize)};
        }
    }
}
