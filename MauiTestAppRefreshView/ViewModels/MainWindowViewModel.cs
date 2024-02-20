using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTestAppRefreshView.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {
        Items = Enumerable.Range(0, 30).ToList();
    }
    
    [RelayCommand]
    public async Task Refresh()
    {
        await Task.Delay(2000);
        IsRefreshing = false;
    }

    [ObservableProperty]
    private bool _isRefreshing;
    
    [ObservableProperty]
    private List<int> _items;
}