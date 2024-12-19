using WpfHobbies.Models;

namespace WpfHobbies.ViewModels
{
    public class HobbyItemViewModel : ViewModelBase
    {
        private readonly Hobby model;

        public HobbyItemViewModel(Hobby model)
        {
            this.model = model;
        }

        public string Name
        {
            get { return model.Name; }
            set { model.Name = value;
                RaisePropertyChanged();
            }
        }

        public int FunRating
        {
            get { return model.FunRating; }
            set
            {
                model.FunRating = value;
                RaisePropertyChanged();
            }
        }
        public bool IsActive
        {
            get { return model.IsActive; }
            set
            {
                model.IsActive = value;
                RaisePropertyChanged();
            }
        }


    }
}
