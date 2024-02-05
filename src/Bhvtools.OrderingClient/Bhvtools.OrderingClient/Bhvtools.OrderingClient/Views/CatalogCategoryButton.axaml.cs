using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Bhvtools.OrderingClient.Views;

public partial class CatalogCategoryButton : UserControl
{
    public static readonly StyledProperty<bool> IsSelectedProperty = SelectingItemsControl.IsSelectedProperty.AddOwner<CatalogCategoryButton>();

    public bool IsSelected
    {
        get => GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }

    public CatalogCategoryButton()
    {
        InitializeComponent();
    }
}