using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;

namespace Bhvtools.OrderingClient.Views;

public partial class CatalogItem : UserControl
{
    private ICommand? addCommand;

    public static readonly DirectProperty<CatalogItem, ICommand?> AddCommandProperty = AvaloniaProperty.RegisterDirect<CatalogItem, ICommand?>(
        "AddCommand", o => o.AddCommand, (o, v) => o.AddCommand = v);

    public ICommand? AddCommand
    {
        get => addCommand;
        set => SetAndRaise(AddCommandProperty, ref addCommand, value);
    }

    private ICommand? removeCommand;

    public static readonly DirectProperty<CatalogItem, ICommand?> RemoveCommandProperty = AvaloniaProperty.RegisterDirect<CatalogItem, ICommand?>(
        "RemoveCommand", o => o.RemoveCommand, (o, v) => o.RemoveCommand = v);

    public ICommand? RemoveCommand
    {
        get => removeCommand;
        set => SetAndRaise(RemoveCommandProperty, ref removeCommand, value);
    } 
    
    public CatalogItem()
    {
        InitializeComponent();
    }
}