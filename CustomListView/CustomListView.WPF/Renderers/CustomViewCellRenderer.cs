using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: ExportRenderer(typeof(CustomListView.Controls.CustomViewCell), typeof(CustomListView.WPF.Renderers.CustomViewCellRenderer))]
namespace CustomListView.WPF.Renderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override System.Windows.DataTemplate GetTemplate(Cell cell)
        {
            var context = cell.BindingContext;

            //var template = App.Current.Resources["ListViewItemTemplate"] as System.Windows.DataTemplate;
            //return template;

            var t = base.GetTemplate(cell);
            return t;
        }
    }
}
