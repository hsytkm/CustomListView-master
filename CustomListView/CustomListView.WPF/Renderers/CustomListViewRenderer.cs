using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: ExportRenderer(typeof(CustomListView.Controls.CustomListView), typeof(CustomListView.WPF.Renderers.CustomListViewRenderer))]
namespace CustomListView.WPF.Renderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
        }

        protected override void UpdateHeight()
        {
            if (Control?.ItemsSource != null)
            {
                foreach (var item in Control.ItemsSource)
                {
                    if (item is ViewCell viewCell && viewCell.View != null)
                    {
                        var element = Platform.GetRenderer(viewCell.View)?.GetNativeElement();
                        if (element != null)
                        {
                            Debug.WriteLine($"CustomListViewRenderer_UpdateHeight_0:{element.Height:f2}");
                        }
                    }
                }
            }

            base.UpdateHeight();

            if (Control?.ItemsSource != null)
            {
                foreach (var item in Control.ItemsSource)
                {
                    if (item is ViewCell viewCell && viewCell.View != null)
                    {
                        var element = Platform.GetRenderer(viewCell.View)?.GetNativeElement();
                        if (element != null)
                        {
                            Debug.WriteLine($"CustomListViewRenderer_UpdateHeight_1:{element.Height:f2}");
                        }
                    }
                }
            }

        }

        protected override void UpdateWidth()
        {
            base.UpdateWidth();

            if (Control != null && Control.ItemsSource != null)
            {
                foreach (var item in Control.ItemsSource)
                {
                    if (item is ViewCell viewCell && viewCell.View != null)
                    {
                        var element = Platform.GetRenderer(viewCell.View)?.GetNativeElement();
                        if (element != null)
                        {
                            element.Width = Control.Width - 36;
                        }
                    }
                }
            }
        }
    }
}
