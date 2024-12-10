using System.Collections.ObjectModel;
using System.Windows.Controls;
using WpfHobbies.Command;
using WpfHobbies.Models;

namespace WpfHobbies.ViewModels
{
    public class HobbiesViewModel : ViewModelBase
    {
        private ObservableCollection<HobbyItemViewModel> hobbies = new();

        public ObservableCollection<HobbyItemViewModel> Hobbies
        {
            get { return hobbies; }

            set
            {
                hobbies = value;
                RaisePropertyChanged();
            }
        }

        private HobbyItemViewModel selectedHobby;

        public HobbyItemViewModel SelectedHobby
        {
            get { return selectedHobby; }
            set
            {
                selectedHobby = value;
                RaisePropertyChanged();
                RemoveCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand AddCommand { get; }
        public DelegateCommand RemoveCommand { get; }

        public HobbiesViewModel()
        {
            hobbies.Add(new HobbyItemViewModel(new Hobby() { Name = "Coding", FunRating = 10, IsActive = true }));
            hobbies.Add(new HobbyItemViewModel(new Hobby() { Name = "Enduro", FunRating = 10, IsActive = false }));
            hobbies.Add( new HobbyItemViewModel(new Hobby() { Name = "Running", FunRating = 3, IsActive = true }));

            AddCommand = new DelegateCommand(AddHobby);
            RemoveCommand = new DelegateCommand(RemoveHobby, CanRemove);
        }

        private void AddHobby(object? parameter)
        {
            Hobby hobby = new Hobby() { Name = "New" };
            var hobbyVM = new HobbyItemViewModel(hobby);
            Hobbies.Add(hobbyVM);
            selectedHobby = hobbyVM;
        }
        private bool CanRemove(object? parameter) => SelectedHobby is not null;
        
        private void RemoveHobby(object? parameter)
        {
            if (SelectedHobby is not null)
            {
                Hobbies.Remove(SelectedHobby);
                SelectedHobby = null;
            }
        }

        public async Task LoadAsync()
        {
            if (Hobbies.Any())
            {
                return;
            }
        }
    }
}
