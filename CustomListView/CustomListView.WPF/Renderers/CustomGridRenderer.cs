using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
using CustomListView.Controls;
using System.Windows.Controls;
using System.Windows.Media;

[assembly: ExportRenderer(typeof(CustomGrid), typeof(CustomListView.WPF.Renderers.CustomGridRenderer))]
namespace CustomListView.WPF.Renderers
{
    public class CustomGridRenderer : ViewRenderer<CustomGrid, System.Windows.Controls.Grid>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomGrid> e)
        {
            base.OnElementChanged(e);
            SetNativeControl(new System.Windows.Controls.Grid()
            {
                Background = Brushes.Red,
                Width = 100,
                Height = 20,
            });
        }
        
        //protected override void UpdateHeight()
        //{
        //    Debug.WriteLine($"Grid.Height0:{Control.Height:f2}");

        //    base.UpdateHeight();

        //    Debug.WriteLine($"Grid.Height1:{Control.Height:f2}");
        //}

    }
}
