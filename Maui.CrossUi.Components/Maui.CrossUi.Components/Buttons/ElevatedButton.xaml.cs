using System.ComponentModel;

using Microsoft.Maui.Handlers;

namespace Maui.CrossUi.Components;

public partial class ElevatedButton : Border 
{
    #region Bindable Properties

    public static readonly BindableProperty PressedCommandProperty = BindableProperty.Create(nameof(PressedCommand), typeof(IRelayCommand), typeof(ElevatedButton), null, BindingMode.TwoWay);

    public IRelayCommand PressedCommand
    {
        get => (IRelayCommand)GetValue(PressedCommandProperty);
        set => SetValue(PressedCommandProperty, value);
    }

    public static readonly BindableProperty PressedCommandParameterProperty = BindableProperty.Create(nameof(PressedCommandParameter), typeof(object), typeof(ElevatedButton), null, BindingMode.TwoWay);

    public object PressedCommandParameter
    {
        get => GetValue(PressedCommandParameterProperty);
        set => SetValue(PressedCommandParameterProperty, value);
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ElevatedButton), default(string), BindingMode.TwoWay);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    #endregion

    public ElevatedButton()
	{
		InitializeComponent();
	}
}