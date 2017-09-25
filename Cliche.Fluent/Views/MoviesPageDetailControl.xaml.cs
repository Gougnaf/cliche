using System;

using Cliche.Fluent.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Cliche.Fluent.Views
{
    public sealed partial class MoviesPageDetailControl : UserControl
    {
        public Movie MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Movie; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(Movie), typeof(MoviesPageDetailControl), new PropertyMetadata(null));

        public MoviesPageDetailControl()
        {
            InitializeComponent();
        }
    }
}
