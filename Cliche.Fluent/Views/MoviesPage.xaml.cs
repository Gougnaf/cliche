using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Cliche.Fluent.Models;
using Cliche.Fluent.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Composition;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Media.Animation;
using System;
using System.Numerics;

namespace Cliche.Fluent.Views
{
    public sealed partial class MoviesPage : Page, INotifyPropertyChanged
    {
        Compositor _compositor;

        private Movie _selected;

        public Movie Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<Movie> SampleItems { get; private set; } = new ObservableCollection<Movie>();

        public MoviesPage()
        {
            InitializeComponent();
            // Connect Animation custom settings, the default animation is 0.8s with no easig and may need to be customized
            _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            var connectedAnimationService = ConnectedAnimationService.GetForCurrentView();
            connectedAnimationService.DefaultDuration = TimeSpan.FromSeconds(1.0);
            connectedAnimationService.DefaultEasingFunction = _compositor.CreateCubicBezierEasingFunction(
                new Vector2(0.41f, 0.52f),
                new Vector2(0.00f, 0.94f)
            );
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetAllMovies();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e?.ClickedItem as Movie;
            if (item != null)
            {
                Selected = item;
                MasterListView.PrepareConnectedAnimation("imageAnimation", item, "MovieThumbImage");
                MasterListView.PrepareConnectedAnimation("nameAnimation", item, "MovieName");
                NavigationService.Navigate<Views.MoviesDetailPage>(item);

                //Add Navigation transition request if necessary
                //NavigationService.Navigate<Views.CharactersPageDetailPage>(item, new DrillInNavigationTransitionInfo());
            }
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
