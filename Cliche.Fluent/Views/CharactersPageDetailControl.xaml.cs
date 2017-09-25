using System;

using Cliche.Fluent.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Cliche.Fluent.Views
{
    public sealed partial class CharactersPageDetailControl : UserControl
    {
        public Character MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Character; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(Character), typeof(CharactersPageDetailControl), new PropertyMetadata(null));

        public CharactersPageDetailControl()
        {
            InitializeComponent();
        }
    }
}
