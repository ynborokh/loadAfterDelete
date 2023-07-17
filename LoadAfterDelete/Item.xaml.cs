using Microsoft.UI.Xaml.Controls;
using System.ComponentModel;
using System.Diagnostics;

namespace LoadAfterDelete;

public sealed partial class Item : UserControl, INotifyPropertyChanged
{
    public Item()
    {
        InitializeComponent();
    }

    private string id;
    public string Id
    {
        get => id;
        set
        {
            if (id != value)
            {
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Debug.WriteLine($"Loaded {((Item)sender).Id}");
    }

    private void OnUnloaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Debug.WriteLine($"Unloaded {((Item)sender).Id}");
    }
}
