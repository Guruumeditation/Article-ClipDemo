using System.Diagnostics;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Microsoft.Xaml.Interactivity;

namespace ClipDemo.Behavior
{
    public class ClippingBehavior : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; private set; }
        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;

            var uie = associatedObject as FrameworkElement;
            if (uie != null)
            {
                uie.Clip = new RectangleGeometry
                {
                    Rect = new Rect(0, 0, uie.ActualWidth, uie.ActualHeight)
                };

                uie.SizeChanged += Uie_SizeChanged;
            }
        }

        private void Uie_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var uie = sender as FrameworkElement;

            uie.Clip = new RectangleGeometry
            {
                Rect = new Rect(new Point(0,0),e.NewSize)
            };

            Debug.WriteLine("size : " + e.NewSize);
        }

        public void Detach()
        {
            var uie = AssociatedObject as FrameworkElement;
            if (uie != null)
            {
                uie.SizeChanged -= Uie_SizeChanged;
            }

            AssociatedObject = null;
        }
    }

}
