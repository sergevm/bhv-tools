using System;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Bhvtools.OrderingClient.Models;
using Bhvtools.OrderingClient.ViewModels;

namespace Bhvtools.OrderingClient.Views;

public partial class CatalogItems : UserControl
{
    private ICommand? addCommand;

    public static readonly DirectProperty<CatalogItems, ICommand?> AddCommandProperty = AvaloniaProperty.RegisterDirect<CatalogItems, ICommand?>(
        "AddCommand", o => o.AddCommand, (o, v) => o.AddCommand = v);

    public ICommand? AddCommand
    {
        get => addCommand;
        set => SetAndRaise(AddCommandProperty, ref addCommand, value);
    }

    private ICommand? removeCommand;

    public static readonly DirectProperty<CatalogItems, ICommand?> RemoveCommandProperty = AvaloniaProperty.RegisterDirect<CatalogItems, ICommand?>(
        "RemoveCommand", o => o.RemoveCommand, (o, v) => o.RemoveCommand = v);

    public ICommand? RemoveCommand
    {
        get => removeCommand;
        set => SetAndRaise(RemoveCommandProperty, ref removeCommand, value);
    }

    private OrderCategoryViewModel? category;

    public static readonly DirectProperty<CatalogItems, OrderCategoryViewModel?> CategoryProperty = AvaloniaProperty.RegisterDirect<CatalogItems, OrderCategoryViewModel?>(
        "Category", o => o.Category, (o, v) => o.Category = v);

    public OrderCategoryViewModel? Category
    {
        get => category;
        set => SetAndRaise(CategoryProperty, ref category, value);
    }
    
    public CatalogItems()
    {
        InitializeComponent();
    }
}