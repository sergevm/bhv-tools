using System.Collections.ObjectModel;
using System.Linq;
using Bhvtools.OrderingClient.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Bhvtools.OrderingClient.ViewModels;

public partial class CatalogViewModel : ObservableObject
{
   [ObservableProperty] private ReadOnlyObservableCollection<CatalogCategoryViewModel> categories;
   [ObservableProperty] private CatalogCategoryViewModel? selectedCategory;

   public CatalogViewModel(Catalog catalog)
   {
      categories = new ReadOnlyObservableCollection<CatalogCategoryViewModel>(
         new ObservableCollection<CatalogCategoryViewModel>(
            catalog.Categories.Select(cat => 
               new CatalogCategoryViewModel(cat))));
   }
}