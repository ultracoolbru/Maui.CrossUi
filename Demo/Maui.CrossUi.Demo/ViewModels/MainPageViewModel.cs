using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;

namespace Maui.CrossUi.Demo.ViewModels;

public partial class MainPageViewModel
{
    [RelayCommand]
    void Test()
    {
        Console.WriteLine("Test");
    }
}
