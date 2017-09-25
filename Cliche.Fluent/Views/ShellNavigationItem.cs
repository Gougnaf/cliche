using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Cliche.Fluent.Views
{
    public class ShellNavigationItem : INotifyPropertyChanged
    {
        public string Label { get; set; }

        public Symbol Symbol { get; set; }

        public Type PageType { get; set; }

        private Visibility _selectedVis = Visibility.Collapsed;

        public Visibility SelectedVis
        {
            get { return _selectedVis; }

            set { Set(ref _selectedVis, value); }
        }

        public char SymbolAsChar
        {
            get { return (char)Symbol; }
        }

        private string _iconElement = null;

        public string Icon
        {
            get
            {
                return _iconElement;
            }
        }

        private bool _isSelected;

        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                Set(ref _isSelected, value);

                SelectedVis = value ? Visibility.Visible : Visibility.Collapsed;

                SelectedForeground = IsSelected
                    ? Application.Current.Resources["SystemControlForegroundAccentBrush"] as SolidColorBrush
                    : GetStandardTextColorBrush();
            }
        }

        private SolidColorBrush _selectedForeground = null;

        public SolidColorBrush SelectedForeground
        {
            get { return _selectedForeground ?? (_selectedForeground = GetStandardTextColorBrush()); }
            set { Set(ref _selectedForeground, value); }
        }

        private ShellNavigationItem(string label, Symbol symbol, Type pageType)
            : this(label, pageType)
        {
            Symbol = symbol;
        }

        private ShellNavigationItem(string label, string icon, Type pageType)
            : this(label, pageType)
        {
            _iconElement = icon;
        }

        private ShellNavigationItem(string label, Type pageType)
        {
            Label = label;
            PageType = pageType;
        }

        public static ShellNavigationItem FromType<T>(string label, Symbol symbol)
            where T : Page
        {
            return new ShellNavigationItem(label, symbol, typeof(T));
        }

        public static ShellNavigationItem FromType<T>(string label, string icon)
            where T : Page
        {
            return new ShellNavigationItem(label, icon, typeof(T));
        }

        private SolidColorBrush GetStandardTextColorBrush()
        {
            var brush = Application.Current.Resources["ThemeControlForegroundBaseHighBrush"] as SolidColorBrush;

            return brush;
        }

        public override string ToString()
        {
            return Label;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
