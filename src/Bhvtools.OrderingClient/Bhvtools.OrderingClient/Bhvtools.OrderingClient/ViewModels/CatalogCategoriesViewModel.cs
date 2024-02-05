using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class CatalogCategoriesViewModel(CatalogViewModel catalog) : ObservableObject
{
    [ObservableProperty] private CatalogViewModel catalog = catalog;
    [ObservableProperty] private CatalogCategoryViewModel? selectedCategory;
}