using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace CustomListView.Controls
{
    public class CustomViewCell : ViewCell
    {
        public CustomViewCell() : base()
        {
            this.Appearing += CustomViewCell_Appearing;
            this.ForceUpdateSizeRequested += CustomViewCell_ForceUpdateSizeRequested;
            this.DescendantAdded += CustomViewCell_DescendantAdded;
            this.BindingContextChanged += CustomViewCell_BindingContextChanged;
        }

        private void CustomViewCell_BindingContextChanged(object sender, EventArgs e)
        {
            var view = View;
            Debug.WriteLine($"CustomViewCell_BindingContextChanged:{view.Height}"); 
        }

        private void CustomViewCell_DescendantAdded(object sender, ElementEventArgs e)
        {
            var view = View;
            Debug.WriteLine($"CustomViewCell_DescendantAdded:{view.Height}");
        }

        private void CustomViewCell_ForceUpdateSizeRequested(object sender, EventArgs e)
        {
            var view = View;
            Debug.WriteLine($"CustomViewCell_ForceUpdateSizeRequested:{view.Height}");
        }

        private void CustomViewCell_Appearing(object sender, EventArgs e)
        {
            var view = View;
            Debug.WriteLine($"CustomViewCell_Appearing:{view.Height}");
        }
    }
}
