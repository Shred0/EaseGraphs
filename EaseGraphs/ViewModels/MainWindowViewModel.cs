using ReactiveUI;
using System;
using System.Runtime.CompilerServices;

namespace EaseGraphs.ViewModels;

public class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel() {
        
    }

    private SidebarMenuViewModel _sidebarMenuViewModel;
    private MainWindowViewModel _mainWindowViewModel;

    private bool _isSidebarMenuOpen = false;
    public bool IsSidebarMenuOpen
    {
        get { return _isSidebarMenuOpen; }
        set { this.RaiseAndSetIfChanged(ref _isSidebarMenuOpen, value); }
    }

    public void ToggleOpenSidebarMenu()
    {
        IsSidebarMenuOpen = !IsSidebarMenuOpen;
    }

}
