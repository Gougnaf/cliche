using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Cliche.Fluent.Models;
using Cliche.Fluent.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Cliche.Fluent.Views
{
    public sealed partial class CharactersPagePage : Page, INotifyPropertyChanged
    {
        Compositor _compositor;

        private Character _selected;

        public Character Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<Character> HeroItems { get; private set; } = new ObservableCollection<Character>();
        public ObservableCollection<Character> MentorItems { get; private set; } = new ObservableCollection<Character>();
        public ObservableCollection<Character> SidekickItems { get; private set; } = new ObservableCollection<Character>();
        public ObservableCollection<Character> VilainItems { get; private set; } = new ObservableCollection<Character>();

        public CharactersPagePage()
        {
            NavigationCacheMode = NavigationCacheMode.Required;

            //TODO Connect Animation custom settings
            _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            var connectedAnimationService = ConnectedAnimationService.GetForCurrentView();
            connectedAnimationService.DefaultDuration = TimeSpan.FromSeconds(1.0);
            connectedAnimationService.DefaultEasingFunction = _compositor.CreateCubicBezierEasingFunction(
                new Vector2(0.41f, 0.52f),
                new Vector2(0.00f, 0.94f)
            );

            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            HeroItems.Clear();
            MentorItems.Clear();
            SidekickItems.Clear();
            VilainItems.Clear();

            var data = await SampleDataService.GetAllCharactersAsync();

            foreach (var item in data)
            {
                switch (item.Category)
                {
                    case Character.Type.Hero:
                        HeroItems.Add(item);
                        break;
                    case Character.Type.Mentor:
                        MentorItems.Add(item);
                        break;
                    case Character.Type.Sidekick:
                        SidekickItems.Add(item);
                        break;
                    case Character.Type.Vilain:
                        VilainItems.Add(item);
                        break;
                }
            }
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //TODO Connect Animation forward source (code)
            var item = e?.ClickedItem as Character;
            if (item != null)
            {
                Selected = item;
                HerosGridView.PrepareConnectedAnimation("characterImage", item, "CharacterThumbImage");
                NavigationService.Navigate<Views.CharactersPageDetailPage>(item);
                
                //TODO Navigation transition request
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

        private async void HerosGridView_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Selected == null) return;

            //TODO Connected Animation backward destination
            Character item = HeroItems.First(h => h.CharacterId == Selected.CharacterId); // Get persisted item
            if (item != null)
            {
                HerosGridView.ScrollIntoView(item);
                ConnectedAnimation animation =
                    ConnectedAnimationService.GetForCurrentView().GetAnimation("characterImage");
                if (animation != null)
                {
                    await HerosGridView.TryStartConnectedAnimationAsync(
                        animation, item, "CharacterThumbImage");
                }
            }
        }
    }
}
