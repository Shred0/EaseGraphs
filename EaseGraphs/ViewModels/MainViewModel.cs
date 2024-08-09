using Avalonia.Interactivity;
using ReactiveUI;
using System.Diagnostics;

namespace EaseGraphs.ViewModels;

public class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        
    }

    private bool _isSidebarMenuOpen = false;
    public bool IsSidebarMenuOpen
    {
        get { return _isSidebarMenuOpen; }
        set { this.RaiseAndSetIfChanged(ref _isSidebarMenuOpen, value); }
    }

    public void ToggleOpenSidebarMenu()
    {
        Debug.WriteLine("hahahah");
        IsSidebarMenuOpen = !IsSidebarMenuOpen;
    }

    public void Button_Click(object source, RoutedEventArgs args)
    {
        ToggleOpenSidebarMenu();
    }


}
