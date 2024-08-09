using ReactiveUI;
using System;
using ReactiveUI;
using System.Windows.Input;
using System.Diagnostics;
using Avalonia.Interactivity;

namespace EaseGraphs.ViewModels;

public class SidebarMenuViewModel : ViewModelBase
{

    public SidebarMenuViewModel()
    {
        //ToggleOpenSidebarMenuCommand = ReactiveCommand.Create(() =>
        //{
        //    // Code here will be executed when the button is clicked.
        //    IsSidebarMenuOpen = !IsSidebarMenuOpen;
        //});
    }

    //public ICommand ToggleOpenSidebarMenuCommand { get; }

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