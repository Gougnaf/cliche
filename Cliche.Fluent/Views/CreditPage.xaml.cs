using Cliche.Fluent.Services;
using System;
using System.ComponentModel;
using System.Numerics;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;

namespace Cliche.Fluent.Views
{
    public sealed partial class CreditPage : Page
    {
        public CreditPage()
        {
            this.InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Items.ItemsSource = await SampleDataService.GetAllAuthors();
        }
    }
}
