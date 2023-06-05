using Maui.CrossUi.Components;
using Maui.CrossUi.Handlers;

namespace Maui.CrossUi;

// All the code in this file is included in all platforms.
public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseCrossUi(this MauiAppBuilder builder)
    {
        builder.ConfigureMauiHandlers(builder => builder
                   //.AddHandler<Label, CrossUiLabelHandler>()
                   .AddHandler(typeof(ElevatedButton), typeof(IElevatedButtonHandler))
                   //.AddHandler<StackLayout, CrossUiStackLayoutHandler>()
                   //.AddHandler<Grid, CrossUiGridHandler>()
                   //.AddHandler<Frame, CrossUiFrameHandler>()
                   //.AddHandler<ScrollView, CrossUiScrollViewHandler>()
                   //.AddHandler<ActivityIndicator, CrossUiActivityIndicatorHandler>()
                   //.AddHandler<ProgressBar, CrossUiProgressBarHandler>()
                   //.AddHandler<Slider, CrossUiSliderHandler>()
                   //.AddHandler<Switch, CrossUiSwitchHandler>()
                   //.AddHandler<CheckBox, CrossUiCheckBoxHandler>()
                   //.AddHandler<DatePicker, CrossUiDatePickerHandler>()
                   //.AddHandler<TimePicker, CrossUiTimePickerHandler>()
                   //.AddHandler<Picker, CrossUiPickerHandler>()
                   //.AddHandler<Stepper, CrossUiStepperHandler>()
                   //.AddHandler<Editor, CrossUiEditorHandler>()
                   //.AddHandler<Entry, CrossUiEntryHandler>()
                   //.AddHandler<Image, CrossUiImageHandler>()
                   //.AddHandler<WebView, CrossUiWebViewHandler>()
                   //.AddHandler<CollectionView, CrossUiCollectionViewHandler>()
                   //.AddHandler<CarouselView, CrossUiCarouselViewHandler>()
                   //.AddHandler<IndicatorView, CrossUiIndicatorViewHandler>()
                   //.AddHandler<ListView, CrossUiListViewHandler>()
                   //.AddHandler<RefreshView, CrossUiRefreshViewHandler>()
                   //.AddHandler<DragGestureRecognizer, CrossUiDragGestureRecognizerHandler>()
                   //.AddHandler<TapGestureRecognizer, CrossUiTapGestureRecognizerHandler>()
                   //.AddHandler<SwipeGestureRecognizer, CrossUiSwipeGestureRecognizerHandler>()
                   //.AddHandler<PinchGestureRecognizer, CrossUiPinchGestureRecognizerHandler>()
                   //.AddHandler<PanGestureRecognizer, CrossUiPanGestureRecognizerHandler>()
                   //.AddHandler<Shell, CrossUiShellHandler>()
                   //.AddHandler<NavigationPage, CrossUiNavigationPageHandler>()
                   //.AddHandler<ContentPage, CrossUiContentPageHandler>()
                   //.AddHandler<CarouselPage, CrossUiCarouselPageHandler>()
                   //.AddHandler<MasterDetailPage, CrossUiMasterDetailPageHandler>()
                   //.AddHandler<TabbedPage, CrossUiTabbedPageHandler>()
                   //.AddHandler<Page, CrossUiPageHandler>()
                   //.AddHandler<CollectionView, CrossUiCollectionViewHandler>()
                   //.AddHandler<CollectionView, CrossUiCollectionViewHandler>()
                   );

        return builder;
    }
}