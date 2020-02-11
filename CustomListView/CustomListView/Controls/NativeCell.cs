using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomListView.Controls
{
    public class NativeCell : ViewCell
    {
        public static readonly BindableProperty NameProperty
            = BindableProperty.Create(nameof(Name), typeof(string), typeof(NativeCell), "");

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

    }
}
