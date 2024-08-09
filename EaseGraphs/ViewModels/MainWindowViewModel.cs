using Avalonia.Metadata;
using ReactiveUI;
using System;
using System.Runtime.CompilerServices;

namespace EaseGraphs.ViewModels;

public class MainWindowViewModel : ViewModelBase
{

    public MainWindowViewModel() {
        //_currentContentView = _mainViewModel;
    }

    // The default is the first page
    //private ViewModelBase _currentContentView;
    //public ViewModelBase CurrentContentView
    //{
    //    get { return _currentContentView; }
    //    private set { this.RaiseAndSetIfChanged(ref _currentContentView, value); }
    //}

    //public MainViewModel _mainViewModel = new MainViewModel();

    public MainViewModel? _MainDataContext = new MainViewModel();
}
