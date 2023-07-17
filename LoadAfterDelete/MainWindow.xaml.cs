using Microsoft.UI.Xaml;
using System;
using System.Linq;

namespace LoadAfterDelete;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnAdd(object sender, RoutedEventArgs e)
    {
        list.Items.Add(Guid.NewGuid().ToString());
    }

    private void OnRemove(object sender, RoutedEventArgs e)
    {
        if (list.Items.Count > 0)
        {
            list.Items.Remove(list.Items.Last());
        }
    }
}
