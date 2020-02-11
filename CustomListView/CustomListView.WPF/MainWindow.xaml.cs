using CustomListView.WPF.Renderers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
using Xamarin.Forms.Platform.WPF.Controls;

namespace CustomListView.WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new CustomListView.App());

#if false
            this.Dispatcher.BeginInvoke(
                new Action(async () =>
                {
                    await Task.Delay(2000);
                    if (TryGetChildControl<FormsPanel>(this, out var child))
                    {
                        if (child.Parent is FormsContentPage parent)
                        {
                            myFormsPanel = new MyFormsPanel(child.Element);
                            myFormsPanel.DataContext = child.DataContext;

                            var panel2 = new MyFormsPanel2(child.Element);
                            panel2.DataContext = child.DataContext;
                            panel2.Width = child.Width;
                            panel2.Height = child.Height;


                            parent.Content = panel2;
                            panel2.UpdateLayout();
                            Debug.WriteLine("Async1");
                            await Task.Delay(2000);

                            //parent.Content = myPanel;
                            //parent.UpdateLayout();


                            parent.Content = child;
                            Debug.WriteLine("Async2");
                            await Task.Delay(2000);

                            parent.Content = panel2;

                        }
                    }
                }));
#endif
        }

        public bool TryGetChildControl<T>(DependencyObject d, out T child)
            where T : DependencyObject
        {
            if (d is T control1)
            {
                child = control1;
                return true;
            }

            var x = VisualTreeHelper.GetChildrenCount(d);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(d); i++)
            {
                if (TryGetChildControl<T>(VisualTreeHelper.GetChild(d, i), out var control2))
                {
                    child = control2;
                    return true;
                }
            }

            child = default;
            return false;
        }
    }
}
