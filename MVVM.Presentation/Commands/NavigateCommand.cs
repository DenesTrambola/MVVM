﻿using MVVM.Presentation.Services;
using MVVM.Presentation.ViewModels;

namespace MVVM.Presentation.Commands;

public class NavigateCommand<TViewModel> : CommandBase
    where TViewModel : ViewModelBase
{
    private readonly NavigationService<TViewModel> _navigationService;

    public NavigateCommand(NavigationService<TViewModel> navigationService) =>
        _navigationService = navigationService;

    public override void Execute(object? parameter) =>
        _navigationService.Navigate();
}
