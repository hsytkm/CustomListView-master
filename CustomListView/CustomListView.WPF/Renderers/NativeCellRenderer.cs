using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: ExportRenderer(typeof(CustomListView.Controls.NativeCell), typeof(CustomListView.WPF.Renderers.NativeCellRenderer))]
namespace CustomListView.WPF.Renderers
{
    public class NativeCellRenderer : ViewCellRenderer
    {
        public override System.Windows.DataTemplate GetTemplate(Cell cell)
        {
            var context = cell.BindingContext;

            Debug.WriteLine($"NativeCellRenderer_GetTemplate:{cell.Height} / {cell.RenderHeight:f2}");
            var template = App.Current.Resources["ListViewItemTemplate"] as System.Windows.DataTemplate;
            return template;
        }
    }
}
