using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace Cliche.Fluent.Views
{
    public sealed partial class MoviePagePage : Page, INotifyPropertyChanged
    {
        public MoviePagePage()
        {
            InitializeComponent();
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

        private void MoviePagePage_OnLoaded(object sender, RoutedEventArgs e)
        {
            ConnectedAnimation imageAnimation =
                ConnectedAnimationService.GetForCurrentView().GetAnimation("movieImage");
            if (imageAnimation != null)
            {
                imageAnimation.TryStart(BackgroundImage);
            }
        }
    }
}
