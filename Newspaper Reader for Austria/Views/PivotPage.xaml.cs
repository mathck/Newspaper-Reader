using Newspaper_Reader_for_Austria.ViewModels;

using Windows.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Newspaper_Reader_for_Austria.Views
{
    public sealed partial class PivotPage : Page
    {
        Compositor _compositor;
        SpriteVisual _hostSprite;

        private PivotViewModel ViewModel { get { return DataContext as PivotViewModel; } }

        public PivotPage()
        {
            InitializeComponent();
        }

        private void applyAcrylicAccent(Panel e)
        {
            _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            _hostSprite = _compositor.CreateSpriteVisual();
            _hostSprite.Size = new Vector2((float) MainGrid.ActualWidth, (float) MainGrid.ActualHeight);

            ElementCompositionPreview.SetElementChildVisual(MainGrid, _hostSprite);
            _hostSprite.Brush = _compositor.CreateHostBackdropBrush();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (_hostSprite != null)
                _hostSprite.Size = e.NewSize.ToVector2();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            applyAcrylicAccent(MainGrid);
            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            CoreApplicationViewTitleBar coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            coreTitleBar.ExtendViewIntoTitleBar = true;
        }
    }
}
