using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Cliche.Fluent.Models;
using Cliche.Fluent.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Cliche.Fluent.Views
{
    public sealed partial class CharactersPagePage : Page, INotifyPropertyChanged
    {
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
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
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
            var item = e?.ClickedItem as Character;
            if (item != null)
            {

                NavigationService.Navigate<Views.CharactersPageDetailPage>(item);
            }
        }
        void PrepareAnimationWithItem(Character item)
        {
            HerosGridView.PrepareConnectedAnimation("characterImage", item, "CharacterThumbImage");
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

        private void RootGrid_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var image = e?.OriginalSource as Image;
            var item = image?.DataContext as Character;
            if (item != null)
            {
                ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("characterImage", image);
                //ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("characterName", image);
                NavigationService.Navigate<Views.CharactersPageDetailPage>(item);
            }
        }
    }
}
